UPDATE 寶可夢_招式
	SET 招式=N'水流噴射'
	WHERE 寶可夢=N'潤水鴨';
UPDATE 招式_屬性_威力 
	SET 威力=60
	WHERE 招式=N'火花';

SELECT 寶可夢,招式 FROM 寶可夢_招式;
SELECT 招式,威力 FROM 招式_屬性_威力;
SELECT 屬性,克制屬性 FROM 屬性_克制屬性_被克制屬性;