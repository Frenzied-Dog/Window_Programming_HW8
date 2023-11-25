INSERT INTO 寶可夢_招式(寶可夢,招式)
	VALUES 
	(N'新葉喵', N'樹葉'),
	(N'呆火鱷', N'火花'),
	(N'潤水鴨', N'水槍');

INSERT INTO 招式_屬性_威力
	VALUES
	(N'樹葉', N'草', 40),
	(N'火花', N'火', 40),
	(N'水槍', N'水', 40);

INSERT INTO 屬性_克制屬性_被克制屬性
	VALUES
	(N'草', N'水', N'火'),
	(N'火', N'草', N'水'),
	(N'水', N'火', N'草');

SELECT * FROM 寶可夢_招式;
SELECT * FROM 招式_屬性_威力;
SELECT * FROM 屬性_克制屬性_被克制屬性;