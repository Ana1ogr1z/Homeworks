select name, 
sum(per_diem) as сумма_суточных from trip
where(trip_id)>3
group by name
order by name;