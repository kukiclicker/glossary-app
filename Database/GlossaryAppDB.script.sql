/*Creating database*/
CREATE DATABASE GlossaryAppDB;
/*Creating Glossary table*/
CREATE TABLE [dbo].[GLOSSARIES] (
    [TermID]     INT           IDENTITY (1, 1) NOT NULL,
    [Term]       VARCHAR (255) NOT NULL,
    [Definition] TEXT          NOT NULL
);
/*Inserting data into table*/
SET IDENTITY_INSERT [dbo].[GLOSSARIES] ON
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (1, N'abyssal plain', N'The ocean floor offshore from the continental margin, usually very flat with a slight slope.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (3, N'alkaline', N'Term pertaining to a highly basic, as opposed to acidic, substance. For example, hydroxide or carbonate of sodium or potassium.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (4, N'biomass', N'The total mass of organisms in a given area or volume.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (5, N'catalyst', N'A substance that increases the rate of a chemical reaction without itself undergoing any permanent chemical change.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (6, N'deforestation', N'The action of clearing a wide area of trees.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (7, N'ecosystem', N'A biological community of interacting organisms and their physical environment.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (8, N'fungicide', N'A chemical that destroys fungal spores, germs, or fungal hyphae.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (9, N'geothermal energy', N'Energy derived from the heat of the earth''s interior.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (10, N'hydroponics', N'A method of growing plants without soil by using mineral nutrient solutions in a water solvent.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (11, N'invasive species', N'Plants, animals, or pathogens that are non-native (alien) to the ecosystem under consideration and whose introduction causes or is likely to cause harm.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (12, N'juxtapose', N'To place or deal with close together for contrasting effect.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (13, N'kinetic energy', N'The energy that an object possesses due to its motion.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (14, N'lithosphere', N'The rigid outer part of the earth, consisting of the crust and upper mantle.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (15, N'mesosphere', N'The region of the earth''s atmosphere above the stratosphere and below the thermosphere, between about 30 and 50 miles (50 and 85 km) in altitude.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (16, N'nuclear fusion', N'A nuclear reaction in which atomic nuclei of low atomic number fuse to form a heavier nucleus with the release of energy.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (17, N'ozone layer', N'A layer in the earth''s stratosphere at an altitude of about 6.2 miles (10 km) containing a high concentration of ozone, which absorbs most of the ultraviolet radiation reaching the earth from the sun.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (18, N'photosynthesis', N'The process by which green plants and some other organisms use sunlight to synthesize foods with the help of chlorophyll pigments.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (19, N'quasar', N'A massive and extremely remote celestial object, emitting exceptionally large amounts of energy.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (20, N'resilience', N'The capacity to recover quickly from difficulties; toughness.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (21, N'sustainable development', N'Development that meets the needs of the present without compromising the ability of future generations to meet their own needs.')
INSERT INTO [dbo].[GLOSSARIES] ([TermID], [Term], [Definition]) VALUES (22, N'nuptials', N'a person''s marriage and marriage celebrations')
SET IDENTITY_INSERT [dbo].[GLOSSARIES] OFF


