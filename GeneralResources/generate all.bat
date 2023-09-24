@echo off
echo.
ResGen.exe KmnlkResources.ar.txt KmnlkResources.ar.resources
echo.

@echo off
echo.
ResGen.exe KmnlkResources.en.txt KmnlkResources.en.resources
echo.

@echo off
echo.
ResGen.exe KmnlkResources.fr.txt KmnlkResources.fr.resources
echo.


lisreset /noforce


copy "KmnlkResources.ar.resources" "..\KmnlkUMSSite\Resources\KmnlkResources.ar.resources"
copy "KmnlkResources.en.resources" "..\KmnlkUMSSite\Resources\KmnlkResources.en.resources"
copy "KmnlkResources.fr.resources" "..\KmnlkUMSSite\Resources\KmnlkResources.fr.resources"


copy "KmnlkResources.ar.resources" "..\KmnlkUMSApi\Resources\KmnlkResources.ar.resources"
copy "KmnlkResources.en.resources" "..\KmnlkUMSApi\Resources\KmnlkResources.en.resources"
copy "KmnlkResources.fr.resources" "..\KmnlkUMSApi\Resources\KmnlkResources.fr.resources"

pause