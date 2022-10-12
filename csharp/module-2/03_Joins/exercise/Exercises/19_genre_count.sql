-- 19. The genre name and the number of movies in each genre. Name the count column 'num_of_movies'.
-- Order the results from the highest movie count to the lowest.
-- (19 rows, the highest expected count is around 400).


select genre.genre_name, count(genre.genre_name) AS num_of_movies from movie
join movie_genre on movie_genre.movie_id = movie.movie_id
join genre on movie_genre.genre_id = genre.genre_id
group by genre.genre_name
order by num_of_movies desc