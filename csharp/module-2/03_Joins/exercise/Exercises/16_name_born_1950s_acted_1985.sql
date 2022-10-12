-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were released in 1985.
-- Order the results by actor from oldest to youngest.
-- (20 rows)

--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select DISTINCT person.person_name, person.birthday from person
join movie_actor on movie_actor.actor_id = person.person_id
join movie on movie.movie_id = movie_actor.movie_id
where person.birthday between '1950-01-01' AND '1959-12-31' AND movie.release_date between '1985-01-01' AND '1985-12-31'
order by person.birthday