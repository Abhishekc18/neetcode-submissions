-- Write your query below
select w.name as warehouse_name,
Sum(p.width * p.length * p.height * w.units) as Volume
from warehouse w
Join products p on w.product_id = p.product_id
group by w.name