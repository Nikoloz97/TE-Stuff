-- ORDERING RESULTS

-- Populations of all states from largest to smallest.




-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.


-- The biggest park by area



-- LIMITING RESULTS

-- The 10 largest cities by populations


-- Get 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.

SELECT top (20) park_name, (YEAR(GETDATE()) - YEAR(date_established)) AS age_in_years FROM park ORDER BY park_name;

Select top(20) date_established, area, park_name FROM park ORDER BY date_established, park_name;

-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.


-- All park names and area

SELECT ('Name: ' + park_name + ', Area:' + CAST(area as VARCHAR)) AS park_and_area FROM park;


-- The census region and state name of all states in the West & Midwest sorted in ascending order.



-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.


-- Total population in the West and South census regions


-- The number of cities with populations greater than 1 million


-- The number of state nicknames.


-- The area of the smallest and largest parks.



-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.

Select state_abbreviation, COUNT(city_name) AS city_count from city GROUP BY state_abbreviation ORDER BY city_count DESC;


-- Determine the average park area depending upon whether parks allow camping or not.


-- Sum of the population of cities in each state ordered by state abbreviation.


-- The smallest city population in each state ordered by city population.



-- Miscelleneous

-- While you can use TOP to limit the number of results returned by a query,
-- it's recommended to use OFFSET and FETCH if you want to get
-- "pages" of results.
-- For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)



-- SUBQUERIES (optional)

-- Include state name rather than the state abbreviation while counting the number of cities in each state,


-- Include the names of the smallest and largest parks


-- List the capital cities for the states in the Northeast census region.

