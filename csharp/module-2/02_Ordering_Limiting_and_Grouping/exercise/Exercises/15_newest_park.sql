-- 15. The name and date established of the newest national park.
-- (1 row)

select top 1 date_established, park_name from park order by date_established desc;