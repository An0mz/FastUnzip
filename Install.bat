@echo off
setlocal

echo.
echo Installing FastUnzip...

:: Create the installation folder
mkdir "C:\FastUnzip" >nul 2>&1

:: Copy the executable
copy "FastUnzip.exe" "C:\FastUnzip\" /Y

:: Install registry keys
C:\FastUnzip\FastUnzip.exe --install

echo.
echo FastUnzip installed successfully!
echo Double-click any .zip file to extract it automatically.
pause

endlocal
exit
