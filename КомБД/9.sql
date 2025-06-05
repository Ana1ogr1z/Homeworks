SELECT _name, SUM(per_diem) AS Сумма_сут
FROM trip.trip
GROUP BY _name