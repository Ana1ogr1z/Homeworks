SELECT _name, SUM(per_diem * datediff(date_last, date_first)) AS Сумма
FROM trip.trip
group by _name
HAVING COUNT(*) > 3