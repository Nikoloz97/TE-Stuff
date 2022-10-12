-- 5. The titles and release dates of all the movies that are in the Comedy genre. 
-- Order the results by release date, earliest to latest. 
-- (220 rows)

--select * from movie
--select * from genre
--select * from movie_genre

select movie.title, movie.release_date from movie
join movie_genre on movie.movie_id = movie_genre.movie_id
join genre on movie_genre.genre_id = genre.genre_id
where genre.genre_name = 'Comedy' 
order by movie.release_date