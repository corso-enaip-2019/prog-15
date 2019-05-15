--Id, porto di partenza e porto di arrivo delle spedizioni in stato "Persa",--
-- oppure in stato "Spedita" e la cui EndDate sia passata rispetto alla data odierna.--

select s.Id,
	   ps.Name,
	   pe.Name
from Shipments as s
join Ports as ps on s.StartPortId = ps.IdPort
join Ports as pe on s.EndPortId = pe.IdPort
where s.State = 'Persa' or (s.State = 'Spedita' and s.EndDate < GETDATE())



--Nome del porto di partenza, nome del porto di arrivo,--
-- numero di giorni del viaggio, ma solo per le spedizioni da o verso l'Italia.--

select f.StartPort,
	   f.EndPort,
	   f.TotalDay
from(
       select s.Id,
      	   ps.Name as StartPort,
      	   pe.Name as EndPort,
      	   ps.CountryId as StartPortId,
      	   pe.CountryId as EndPortId,
      	   datediff(day,s.StartDate,s.EndDate) as [TotalDay]
      from Shipments as s
      join Ports as ps on s.StartPortId = ps.IdPort
      join Ports as pe on s.EndPortId = pe.IdPort
	  ) as f
join Countries as cs on cs.IdCountry = f.StartPortId
join Countries as ce on ce.IdCountry = f.EndPortId 

where cs.Country = 'Italia' or ce.Country = 'Italia'



--Nome del paese e peso totale delle spedizioni (Kg) da quel paese, solo per il 2019--

select c.Country,
	   sum(f.Kg)
from (select *
      from Shipments as s
      join Ports as p on s.StartPortId = p.IdPort
      where s.StartDate between '01-01-2019' and '31-12-2019'
	  ) as f
join Countries as c on f.CountryId = c.IdCountry
group by c.Country


--Nome città, massimo peso tra tutte le spedizioni in arrivo,-- 
-- ma solo tra quelle di tipo "Alimentari" o "Alimentari da congelare".--

select p.City,
	   max(s.Kg)
from Shipments as s
join Ports as p on s.EndPortId = p.IdPort
where s.Kind = 'Alimentari' or s.Kind = 'Alimentari da congelare'
group by City


