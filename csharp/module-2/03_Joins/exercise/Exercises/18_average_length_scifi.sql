-- 18. The average length of movies in the "Science Fiction" genre. Name the column 'average_length'.
-- (1 row, expected result between 110-120)

--select * from movie
--select * from genre
--select * from movie_genre
--select * from person

select avg(movie.length_minutes) AS average_length from movie
join movie_genre on movie_genre.movie_id = movie.movie_id
join genre on movie_genre.genre_id = genre.genre_id
where genre.genre_name = 'Science Fiction'
