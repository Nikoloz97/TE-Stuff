-- 1. The titles and release dates of movies that Tom Hanks has appeared in. 
-- Order the results by release date, newest to oldest.
-- (47 rows)


--select * from movie
--select * from movie_actor
--select * from person

select movie.title, movie.release_date from movie
join movie_actor on movie.movie_id = movie_actor.movie_id
join person on movie_actor.actor_id = person.person_id
where person.person_name = 'Tom Hanks'
order by movie.release_date desc