-- 8. The genres of movies that Robert De Niro has appeared in that were released in 2010 or later, sorted alphabetically.
-- (6 rows)

--select * from movie
--select * from genre
--select * from movie_genre
--select * from person


--select movie.title, genre.genre_name from genre
--join movie_genre on genre.genre_id = movie_genre.genre_id
--join movie on movie_genre.movie_id = movie.movie_id
--join movie_actor on movie_actor.movie_id = movie.movie_id
--join person on movie_actor.actor_id = person.person_id
--where person.person_name = 'Robert De Niro' AND movie.release_date >= '2010-01-01'
--order by genre.genre_name


select distinct genre.genre_name from genre
join movie_genre on genre.genre_id = movie_genre.genre_id
join movie on movie_genre.movie_id = movie.movie_id
join movie_actor on movie_actor.movie_id = movie.movie_id
join person on movie_actor.actor_id = person.person_id
where person.person_name = 'Robert De Niro' AND movie.release_date >= '2010-01-01'
order by genre.genre_name

