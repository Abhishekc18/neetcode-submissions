
select 
    s.seller_name
from 
    seller s
left Join Orders o 
    on o.seller_id = s.seller_id
    and extract(Year from o.sale_date) = 2020
where o.order_id is null
order by s.seller_name