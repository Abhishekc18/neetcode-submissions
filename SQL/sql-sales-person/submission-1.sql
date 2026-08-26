select s.name
from sales_person s
where not exists (
    select 1
    from orders o 
    left join company c 
        on o.com_id = c.com_id
    where s.sales_id = o.sales_id
    and c.name = 'CRIMSON'
)