Database Migration 


Hvis der skal tilføjes en ny migration: 
Add-Migration ProjectName Patch_00_00_01 

Hvis den samme migration skal overrides/updates: 
Add-Migration ProjectName Patch_00_00_01 -Force 

Hvis der skal rollbackes til en tidligere database stadie: 
Update-Database -TargetMigration Patch_00_00_01

