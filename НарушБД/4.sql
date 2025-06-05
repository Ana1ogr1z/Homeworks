SELECT city, COUNT(city) AS самые_посещаемые_города
FROM trip
GROUP BY city
order by count(city) desc
limit 2;