-- 7. Remove the actor appearances in "Avengers: Infinity War" (14 rows)
-- Note: Don't remove the actors themeselves, just make it so it seems no one appeared in the movie.

--select * from movie_actor
--select movie_id from movie where title = 'Avengers: Infinity War' 

delete from movie_actor
where movie_id = 299536 


