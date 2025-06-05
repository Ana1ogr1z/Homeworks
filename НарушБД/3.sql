SELECT city, COUNT(city) AS количество_посещений
FROM trip  
GROUP BY city 