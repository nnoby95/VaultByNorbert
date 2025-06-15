# Hungarian Date Parsing Fix

## Problem
Reports failed to upload with error: `Unable to parse datetime string: jún. 07, 23:42`

## Solution Applied
Modified `/app/TW.Vault.App/wwwroot/lib/lib.js` to add Hungarian month support:

1. Added Hungarian month mappings (line ~160)
2. Updated regex pattern to include Hungarian months (line ~191)  
3. Added fallback logic to check Hungarian months (line ~301)

## Supported Formats
- Abbreviated: `jún. 07, 23:42`
- Full names: `június 07, 23:42`
- All 12 months in Hungarian

## Note
This is a temporary fix. Proper solution is to add Hungarian translations to the database.

## Testing
After deployment, test with: `lib.parseDateTime('jún. 07, 23:42')`
