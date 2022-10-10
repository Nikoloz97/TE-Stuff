-- 23. The name and date established of parks opened in the 1960s (6 rows)

select park_name, date_established from park WHERE date_established >= '1960-01-01' AND date_established <= '1969-12-31';