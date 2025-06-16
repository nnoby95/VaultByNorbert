-- Hungarian Date Parsing Fix
-- Apply these after running the main Hungarian translation

-- CRITICAL: Keep ORDERED_MONTHS in English for internal parsing
UPDATE feature.translation 
SET value = 'jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec'
WHERE translation_id = 2 AND key = 448;

-- Add Hungarian date format patterns
UPDATE feature.translation 
SET value = E'yyyy.MM.dd\nyyyy/MM/dd\ndd/MM/yyyy\n{monthName} {day}\n{monthName} {day}, {year}'
WHERE translation_id = 2 AND key = 558;

-- Add Hungarian datetime format patterns with milliseconds support
UPDATE feature.translation 
SET value = E'yyyy.MM.dd HH:mm:ss\nyyyy/MM/dd HH:mm:ss\nHH:mm:ss dd/MM/yyyy\nH:mm:ss dd/MM/yyyy\n{monthName} {day}, {hour}:{minute}\n{hour}:{minute}:{second} {day}/{month}/{year}\n{monthName} {day}, {year} {hour}:{minute}:{second}:{millis}\n{monthName} {day}, {year}  {hour}:{minute}:{second}:{millis}'
WHERE translation_id = 2 AND key = 559;
