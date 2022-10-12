-- 7. The genres of movies that Christopher Lloyd has appeared in, sorted alphabetically.
-- (8 rows) Hint: DISTINCT will prevent duplicate values in your query results.

--select * from movie
--select * from genre
--select * from movie_genre

select distinct genre.genre_name from genre
join movie_genre on genre.genre_id = movie_genre.genre_id
join movie_actor on movie_actor.movie_id = movie_genre.movie_id
join person on movie_actor.actor_id = person.person_id
where person.person_name = 'Christopher Lloyd' 
order by genre.genre_name