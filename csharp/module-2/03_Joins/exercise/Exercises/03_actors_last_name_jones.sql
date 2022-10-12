-- 3. For all actors with the last name of "Jones", display the actor's name and movie titles they appeared in. 
-- Order the results by the actor names (A-Z) and then by movie title (A-Z). 
-- (48 rows)

--select * from movie
--select * from movie_actor
--select * from person

select person.person_name, movie.title from movie
join movie_actor on movie.movie_id = movie_actor.movie_id
join person on  movie_actor.actor_id = person.person_id
where person.person_name like '% Jones'
order by person.person_name, movie.title