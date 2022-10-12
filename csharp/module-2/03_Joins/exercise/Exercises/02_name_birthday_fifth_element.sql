-- 2. The names and birthdays of actors in "The Fifth Element"
-- Order the results alphabetically (A-Z) by name.
-- (15 rows)

--select * from movie
--select * from movie_actor
--select * from person

select person.person_name, person.birthday from movie
join movie_actor on movie.movie_id = movie_actor.movie_id
join person on  movie_actor.actor_id = person.person_id
where movie.title = 'The Fifth Element'
order by person.person_name
