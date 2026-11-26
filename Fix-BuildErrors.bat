@echo off
setlocal EnableExtensions EnableDelayedExpansion
chcp 65001 >nul
title DSA Project - Fix Build Errors
color 0B

rem ============================================================================
rem  DSA Project - one-click repair script  (Windows)
rem
rem  It fixes the two problems that break the build on a freshly downloaded
rem  copy of this project:
rem
rem   (1) "Couldn't process file Forms\X.resx due to its being in the Internet
rem        or Restricted zone or having the mark of the web on the file."
rem
rem       Cause: the project came from the internet as a .zip, so Windows put
rem              a "mark of the web" on every file. ResGen refuses to read
rem              .resx files that carry that mark.
rem       Fix  : remove the mark from every file (Unblock-File).
rem
rem   (2) "The name 'picSearch' does not exist in the current context."
rem       "Visual Studio cannot start debugging because the debug target ...
rem        \bin\Debug\DSA Project.exe is missing."
rem
rem       Cause: old build output left behind by a failed build.
rem       Fix  : delete bin\ , obj\ and .vs\ folders.
rem
rem  How to use:
rem    1. Put this .bat file anywhere inside the project folder
rem       (the folder that contains "DSA Project.sln").
rem    2. Double-click it and wait for "DONE".
rem    3. Open "DSA Project.sln" in Visual Studio and press F5.
rem ============================================================================

set "ROOT=%~dp0"
if "%ROOT:~-1%"=="\" set "ROOT=%ROOT:~0,-1%"

echo.
echo ============================================================
echo   DSA Project - Fix Build Errors
echo ============================================================
echo   folder: %ROOT%
echo.

rem ---------- locate the solution (.sln) automatically ----------
set "SLN="
for /r "%ROOT%" %%S in (*.sln) do (
    if not defined SLN set "SLN=%%S"
)
if not defined SLN (
    echo [X] No ".sln" file found inside this folder.
    echo     Make sure you run this file from inside the project folder
    echo     ^(the one that contains "DSA Project.sln"^).
    echo.
    pause
    exit /b 1
)
for %%S in ("%SLN%") do set "SLNDIR=%%~dpS"
set "SLNDIR=%SLNDIR:~0,-1%"
echo   solution: %SLN%
echo.

rem ---------- [1/4] remove the mark of the web ----------
echo [1/4] Removing the "mark of the web" from all files ...
rem the folder path is passed through an environment variable, so spaces,
rem quotes or apostrophes in the path cannot break the PowerShell command
set "DSA_ROOT=%ROOT%"
powershell -NoProfile -ExecutionPolicy Bypass -Command ^
  "$root=$env:DSA_ROOT; $n=0; Get-ChildItem -LiteralPath $root -Recurse -File -Force -ErrorAction SilentlyContinue | Where-Object { $_.FullName -notmatch '\\.git\\' } | ForEach-Object { try { if (Get-Item -LiteralPath $_.FullName -Stream Zone.Identifier -ErrorAction SilentlyContinue) { Unblock-File -LiteralPath $_.FullName; $n++ } } catch {} }; Write-Host ('      unblocked ' + $n + ' file(s)')"
if errorlevel 1 (
    echo [X] Unblock step failed.
    echo     Right-click this .bat file, choose "Run as administrator", retry.
    echo.
    pause
    exit /b 1
)

rem ---------- [2/4] delete stale build output ----------
echo [2/4] Deleting old build output (bin, obj, .vs) ...
set "REMOVED=0"
for /d /r "%ROOT%" %%D in (bin) do (
    if exist "%%D" (
        rmdir /s /q "%%D" >nul 2>&1
        if not exist "%%D" set /a REMOVED+=1
    )
)
for /d /r "%ROOT%" %%D in (obj) do (
    if exist "%%D" (
        rmdir /s /q "%%D" >nul 2>&1
        if not exist "%%D" set /a REMOVED+=1
    )
)
for /d /r "%ROOT%" %%D in (.vs) do (
    if exist "%%D" rmdir /s /q "%%D" >nul 2>&1
)
echo       removed !REMOVED! build folder(s)

rem ---------- [3/4] sanity check the source tree ----------
echo [3/4] Checking that the project files are all present ...
set "MISSING=0"
call :check "Program.cs"
call :check "Forms\BookingHistory.cs"
call :check "Forms\BookingHistory.Designer.cs"
call :check "Forms\BookingHistory.resx"
call :check "Forms\SeatSelection.resx"
call :check "Forms\AddMovieForm.resx"
if "%MISSING%"=="1" (
    echo.
    echo [X] Some source files are missing - the download is incomplete.
    echo     Clone it again:  git clone ^<repository url^>
    echo.
    pause
    exit /b 1
)
for /r "%SLNDIR%" %%P in (*.csproj) do if not defined PROJ set "PROJ=%%P"
if defined PROJ (
    for %%P in ("!PROJ!") do set "PROJDIR=%%~dpP"
    set "PROJDIR=!PROJDIR:~0,-1!"
    echo       project: !PROJ!
)
echo       all required files are present

rem ---------- [4/4] build, to prove the code compiles ----------
echo [4/4] Looking for Visual Studio / MSBuild ...
set "MSBUILD="
set "VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"
if exist "%VSWHERE%" (
    for /f "usebackq delims=" %%I in (`"%VSWHERE%" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe 2^>nul`) do (
        if not defined MSBUILD set "MSBUILD=%%I"
    )
)
if not defined MSBUILD if exist "%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe"

if not defined MSBUILD (
    echo       not found on this machine - skipping the test build.
    echo       That is fine: just open the .sln in Visual Studio and use
    echo       Build ^> Rebuild Solution.
    goto :done
)

echo       found: !MSBUILD!
echo.
echo       Building now (this proves the code compiles) ...
echo.
"!MSBUILD!" "%SLN%" /t:Rebuild /p:Configuration=Debug /v:minimal /nologo
if errorlevel 1 (
    echo.
    echo [X] The build FAILED. Read the errors printed above.
    echo     Nothing else here can fix a real code error, so send them over.
    echo.
    pause
    exit /b 1
)

echo.
echo       BUILD SUCCEEDED.
if defined PROJDIR (
    echo       output: !PROJDIR!\bin\Debug\DSA Project.exe
    if exist "!PROJDIR!\bin\Debug\DSA Project.exe" echo       .exe exists: YES
)

:done
echo.
echo ============================================================
echo   DONE.
echo   1. Close Visual Studio if it is open.
echo   2. Open "DSA Project.sln" again.
echo   3. Build ^> Rebuild Solution, then press F5.
echo ============================================================
echo.
pause
exit /b 0

rem ---------------------------------------------------------------------------
:check
rem %~1 = path relative to the solution folder
set "FOUND="
for /r "%SLNDIR%" %%F in ("%~nx1") do if not defined FOUND set "FOUND=%%F"
if not defined FOUND (
    echo       [X] missing: %~1
    set "MISSING=1"
)
exit /b 0
