UPDATE fine
SET sum_fine = 500
WHERE violation = "Превышение скорости(от 20 до 40)";

UPDATE fine
SET sum_fine = 1000
WHERE violation = "Превышение скорости(от 40 до 60)";

UPDATE fine
SET sum_fine = 1000
WHERE violation = "Проезд на запрещающий сигнал"