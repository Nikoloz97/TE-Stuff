-- 9. The titles of movies directed by James Cameron, sorted alphabetically.
-- (6 rows)


--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select distinct title from movie
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie.director_id = person.person_id

where person.person_name = 'James Cameron'
order by title