@echo off
setlocal enabledelayedexpansion

set /p "count=Kac tane server acmak istiyorsun: "
set /p "countC=Kac tane client acmak istiyorsun: "


for /l %%i in (1, 1, %count%) do (
    start /d "C:\Users\mmura\OneDrive\Belgeler\GitHub\MultiplayerGameBootcampMuratDilmac\Build\" MultiplayerGameBootcampLesson.exe isWindowedMode=true server=true
)
for /l %%i in (1, 1, %countC%) do (
    start /d "C:\Users\mmura\OneDrive\Belgeler\GitHub\MultiplayerGameBootcampMuratDilmac\Build\" MultiplayerGameBootcampLesson.exe isWindowedMode=true client=true
)

endlocal
