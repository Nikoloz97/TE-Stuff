-- 15. The title of the movie and the name of director for movies where the director was also an actor in the same movie.
-- Order the results by movie title (A-Z)
-- (73 rows)

--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select distinct movie.title, person.person_name from movie
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie.director_id = person.person_id
where movie_actor.actor_id = movie.director_id
order by movie.title