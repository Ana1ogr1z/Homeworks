SELECT city, COUNT(*) AS Кол_командировок
FROM trip.trip
GROUP BY city
ORDER BY COUNT(*) DESC
LIMIT 2
