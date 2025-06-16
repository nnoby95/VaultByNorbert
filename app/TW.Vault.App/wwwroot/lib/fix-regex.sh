#!/bin/bash
# Read the file
content=$(cat lib.js)

# Fix line 298 - replace the broken regex
old_pattern='var simpleTimeFirst = dateString.match(/^(\d{1,2}):(\d{2}):(\d{2})\s+(\d{1,2})/(\d{1,2})/(\d{4})$/);'
new_pattern='var simpleTimeFirst = dateString.match(/^(\d{1,2}):(\d{2}):(\d{2})\s+(\d{1,2})\/(\d{1,2})\/(\d{4})$/);'

# Replace
echo "$content" | sed "s|$old_pattern|$new_pattern|g" > lib.js.fixed
mv lib.js.fixed lib.js
