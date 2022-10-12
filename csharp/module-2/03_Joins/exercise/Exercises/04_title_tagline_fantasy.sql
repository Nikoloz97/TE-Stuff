-- 4. The titles and taglines of all the movies that are in the Fantasy genre. 
-- Order the results by title (A-Z).
-- (81 rows)

--select * from movie
--select * from genre
--select * from movie_genre

select movie.title, movie.tagline from movie
join movie_genre on movie.movie_id = movie_genre.movie_id
join genre on movie_genre.genre_id = genre.genre_id
where genre.genre_name = 'Fantasy' 
order by movie.title