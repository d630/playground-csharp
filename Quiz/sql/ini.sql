-- START TRANSACTION;

SET foreign_key_checks=0;

DROP DATABASE IF EXISTS quiz;
CREATE DATABASE quiz;
USE quiz;

-- TABLES.

CREATE TABLE player (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    nick_name VARCHAR(255) UNIQUE NOT NULL,
    rounds_total INTEGER NOT NULL DEFAUlt 0,
    high_score INTEGER NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE country (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    c_name VARCHAR(255) UNIQUE NOT NULL,
    capital_name VARCHAR(255) NOT NULL,
    c_code CHAR(2) UNIQUE DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- PROCEDURES.

DELIMITER //

CREATE PROCEDURE set_player
(IN _nick_name VARCHAR(255))
BEGIN
    INSERT INTO player(nick_name)
    VALUES(_nick_name);
END //

CREATE PROCEDURE update_player
(IN _id INTEGER, _rounds_total INTEGER, IN _high_score INTEGER)
BEGIN
    UPDATE player
    SET rounds_total = _rounds_total, high_score = _high_score
    WHERE id = _id;
END //

CREATE PROCEDURE get_player_by_id
(IN _id INTEGER)
BEGIN
    SELECT *
    FROM player
    WHERE id = _id;
END //

CREATE PROCEDURE get_player_by_id
(IN _id INTEGER)
BEGIN
    SELECT *
    FROM player
    WHERE id = _id;
END //

CREATE PROCEDURE get_player_by_nick_name
(IN _nick_name VARCHAR(255))
BEGIN
    SELECT *
    FROM player
    WHERE nick_name = _nick_name;
END //

CREATE PROCEDURE get_players_by_high_score
()
BEGIN
    SELECT *
    FROM player
    ORDER BY high_score DESC, rounds_total DESC;
END //

CREATE PROCEDURE get_players_by_high_score_named
()
BEGIN
    SELECT nick_name AS Nickname, rounds_total as Rounds, high_score AS Highscore
    FROM player
    ORDER BY high_score DESC, rounds_total DESC;
END //

CREATE PROCEDURE get_random_countries
(IN _n INTEGER)
BEGIN
    SELECT c_name, capital_name, c_code
    FROM country
    ORDER BY RAND()
    LIMIT _n;
END //

DELIMITER ;

-- INSERTIONS.

-- INSERT INTO player(nick_name)
-- VALUES
-- ('user1'),
-- ('user2'),
-- ('user3'),
-- ('user4');

-- INSERT INTO player(nick_name, rounds_total, high_score)
-- VALUES
-- ('user5', 66, 1200);

-- 233 countries
INSERT INTO country(c_name, capital_name, c_code)
VALUES
('Afghanistan', 'Kabul', 'af'),
('Albania', 'Tirana', 'al'),
('Algeria', 'Algiers', 'dz'),
('American Samoa', 'Pago Pago', 'as'),
('Andorra', 'Andorra la Vella', 'ad'),
('Angola', 'Luanda', 'ao'),
('Anguilla', 'The Valley', 'ai'),
('Antigua and Barbuda', 'St John''s', 'ag'),
('Argentina', 'Buenos Aires', 'ar'),
('Armenia', 'Yerevan', 'am'),
('Aruba', 'Oranjestad', 'aw'),
('Australia', 'Canberra', 'au'),
('Austria', 'Vienna', 'at'),
('Azerbaijan', 'Baku', 'az'),
('The Bahamas', 'Nassau', 'bs'),
('Bahrain', 'Manama', 'bh'),
('Bangladesh', 'Dhaka', 'bd'),
('Barbados', 'Bridgetown', 'bb'),
('Belarus', 'Minsk', 'by'),
('Belgium', 'Brussels', 'be'),
('Belize', 'Belmopan', 'bz'),
('Benin', 'Porto Novo', 'bj'),
('Bermuda', 'Hamilton', 'bm'),
('Bhutan', 'Thimphu', 'bt'),
('Bolivia', 'Sucre', 'bo'),
('Bosnia and Herzegovina', 'Sarajevo', 'ba'),
('Botswana', 'Gaborone', 'bw'),
('Bouvet Island', '-', 'bv'),
('Brazil', 'Brasilia', 'br'),
('British Virgin Islands', 'Road Town', 'vg'),
('Brunei', 'Bandar Seri Begawan', 'bn'),
('Bulgaria', 'Sofia', 'bg'),
('Burkina Faso', 'Ouagadougou', 'bf'),
('Burundi', 'Bujumbura', 'bi'),
('Cambodia', 'Phnom Penh', 'kh'),
('Cameroon', 'Yaound', 'cm'),
('Canada', 'Ottawa', 'ca'),
('Cape Verde', 'Praia', 'cv'),
('Cayman Islands', 'George Town', 'ky'),
('Central African Republic', 'Bangui', 'cf'),
('Chad', 'N''Djamena', 'td'),
('Chile', 'Santiago', 'cl'),
('China', 'Beijing', 'cn'),
('Hong Kong', 'Victoria City', 'hk'),
('Macau', 'Macau', 'mo'),
('Christmas Island', 'Flying Fish Cove', 'cx'),
('Cocos (Keeling) Islands', 'Bantam', 'cc'),
('Colombia', 'Santa Fe de Bogot', 'co'),
('Comoros', 'Moroni', 'km'),
('Congo', 'Brazzaville', 'cg'),
('Democratic Republic of the Congo', 'Kinshasa', 'cd'),
('Cook Islands', 'Avarua', 'ck'),
('Costa Rica', 'San Jos', 'cr'),
('Cote D''Ivoire', 'Yamoussoukro', 'ci'),
('Croatia', 'Zagreb', 'hr'),
('Cuba', 'Havana', 'cu'),
('Cyprus', 'Nicosia', 'cy'),
('Czech Republic', 'Prague', 'cz'),
('Denmark', 'Copenhagen', 'dk'),
('Djibouti', 'Djibouti', 'dj'),
('Dominica', 'Roseau', 'dm'),
('Dominican Republic', 'Santo Domingo', 'do'),
('Ecuador', 'Quito', 'ec'),
('Egypt', 'Cairo', 'eg'),
('El Salvador', 'San Salvador', 'sv'),
('Equatorial Guinea', 'Malabo', 'gq'),
('Eritrea', 'Asmara', 'er'),
('Estonia', 'Tallinn', 'ee'),
('Ethiopia', 'Addis Ababa', 'et'),
('Falkland Islands', 'Stanley', 'fk'),
('Faeroe Islands', 'Thorshavn', 'fo'),
('Fiji', 'Suva', 'fj'),
('Finland', 'Helsinki', 'fi'),
('France', 'Paris', 'fr'),
('French Guiana', 'Cayenne', 'gf'),
('French Polynesia', 'Papeete', 'pf'),
('Gabon', 'Libreville', 'ga'),
('The Gambia', 'Banjul', 'gm'),
('Georgia', 'Tbilisi', 'ge'),
('Germany', 'Berlin', 'de'),
('Ghana', 'Accra', 'gh'),
('Gibraltar', 'Gibraltar', 'gi'),
('Greece', 'Athens', 'gr'),
('Greenland', 'Nuuk', 'gl'),
('Grenada', 'St George''s', 'gd'),
('Guadeloupe', 'Basse Terre', 'gp'),
('Guam', 'Hagtana', 'gu'),
('Guatemala', 'Guatemala City', 'gt'),
('Guinea', 'Conakry', 'gn'),
('Guinea-Bissau', 'Bissau', 'gw'),
('Guyana', 'Georgetown', 'gy'),
('Haiti', 'Port-au-Prince', 'ht'),
('The Hoy See (Vatican City State)', 'Vatican City', 'va'),
('Honduras', 'Tegucigalpa', 'hn'),
('Hungary', 'Budapest', 'hu'),
('Iceland', 'Reykjavik', 'is'),
('India', 'New Delhi', 'in'),
('Indonesia', 'Jakarta', 'id'),
('Iran', 'Tehran', 'ir'),
('Iraq', 'Baghdad', 'iq'),
('Ireland', 'Dublin', 'ie'),
('Israel', 'Jerusalem', 'il'),
('Italy', 'Rome', 'it'),
('Jamaica', 'Kingston', 'jm'),
('Japan', 'Tokyo', 'jp'),
('Jordan', 'Amman', 'jo'),
('Kazakhstan', 'Astana', 'kz'),
('Kenya', 'Nairobi', 'ke'),
('Kiribati', 'Tarawa', 'ki'),
('North Korea', 'Pyongyang', 'kp'),
('South Korea', 'Seoul', 'kr'),
('Kuwait', 'Kuwait City', 'kw'),
('Kyrgyzstan', 'Bishkek', 'kg'),
('Laos', 'Vientiane', 'la'),
('Latvia', 'Riga', 'lv'),
('Lebanon', 'Beirut', 'lb'),
('Lesotho', 'Maseru', 'ls'),
('Liberia', 'Monrovia', 'lr'),
('Libya', 'Tripoli', 'ly'),
('Liechtenstein', 'Vaduz', 'li'),
('Lithuania', 'Vilnius', 'lt'),
('Luxembourg', 'Luxembourg', 'lu'),
('Former Yugoslav Republic of Macedonia', 'Skopje', 'mk'),
('Madagascar', 'Antananarivo', 'mg'),
('Malawi', 'Lilongwe', 'mw'),
('Malaysia', 'Kuala Lumpur', 'my'),
('Maldives', 'Male', 'mv'),
('Mali', 'Bamako', 'ml'),
('Malta', 'Valletta', 'mt'),
('Marshall Islands', 'Majuro', 'mh'),
('Martinique', 'Fort-de-France', 'mq'),
('Mauritania', 'Nouakchott', 'mr'),
('Mauritius', 'Port Louis', 'mu'),
('Mayotte', 'Mamoudzou', 'yt'),
('Mexico', 'Mexico City', 'mx'),
('Micronesia', 'Palikir', 'fm'),
('Moldova', 'Chisinau', 'md'),
('Monaco', 'Monaco', 'mc'),
('Mongolia', 'Ulan Bator', 'mn'),
('Montserrat', 'Plymouth', 'ms'),
('Morocco', 'Rabat', 'ma'),
('Mozambique', 'Maputo', 'mz'),
('Myanmar', 'Yangon', 'mm'),
('Namibia', 'Windhoek', 'na'),
('Nauru', 'Yaren', 'nr'),
('Nepal', 'Kathmandu', 'np'),
('Netherlands', 'Amsterdam', 'nl'),
('Netherlands Antilles', 'Willemstad', 'an'),
('New Caledonia', 'Noumea', 'nc'),
('New Zealand', 'Wellington', 'nz'),
('Nicaragua', 'Managua', 'ni'),
('Niger', 'Niamey', 'ne'),
('Nigeria', 'Abuja', 'ng'),
('Niue', 'Alofi', 'nu'),
('Norfolk Island', 'Kingston', 'nf'),
('Northern Marianas', 'Garapan', 'mp'),
('Norway', 'Oslo', 'no'),
('Oman', 'Muscat', 'om'),
('Pakistan', 'Islamabad', 'pk'),
('Palau', 'Koror', 'pw'),
('Panama', 'Panama City', 'pa'),
('Papua New Guinea', 'Port Moresby', 'pg'),
('Paraguay', 'Asuncion', 'py'),
('Peru', 'Lima', 'pe'),
('Philippines', 'Manila', 'ph'),
('Pitcairn Islands', 'Adamstown', 'pn'),
('Poland', 'Warsaw', 'pl'),
('Portugal', 'Lisbon', 'pt'),
('Puerto Rico', 'San Juan', 'pr'),
('Qatar', 'Doha', 'qa'),
('Reunion', 'Saint-Denis', 're'),
('Romania', 'Bucharest', 'ro'),
('Russia', 'Moscow', 'ru'),
('Rwanda', 'Kigali', 'rw'),
('Saint Helena', 'Jamestown', 'sh'),
('Saint Kitts and Nevis', 'Basseterre', 'kn'),
('Saint Lucia', 'Castries', 'lc'),
('Saint Pierre and Miquelon', 'Saint-Pierre', 'pm'),
('Saint Vincent and the Grenadines', 'Kingstown', 'vc'),
('Samoa', 'Apia', 'ws'),
('San Marino', 'San Marino', 'sm'),
('Sao tome and principle', 'Sao Tome & Principe Dobra', 'st'),
('Saudi Arabia', 'Riyadh', 'sa'),
('Senegal', 'Dakar', 'sn'),
('Serbia', 'Belgrade', 'rs'),
('Seychelles', 'Victoria', 'sc'),
('Sierra Leone', 'Freetown', 'sl'),
('Singapore', 'Singapore', 'sg'),
('Slovakia', 'Bratislava', 'sk'),
('Slovenia', 'Ljubljana', 'si'),
('Solomon Islands', 'Honiara', 'sb'),
('Somalia', 'Mogadishu', 'so'),
('South Africa', 'Pretoria', 'za'),
('South Sudan', 'Juba', 'ss'),
('Spain', 'Madrid', 'es'),
('Sri Lanka', 'Colombo', 'lk'),
('Sudan', 'Khartoum', 'sd'),
('Suriname', 'Paramaribo', 'sr'),
('Svalbard and Jan Mayen', 'Longyearbyen', 'sj'),
('Swaziland', 'Mbabane', 'sz'),
('Sweden', 'Stockholm', 'se'),
('Switzerland', 'Berne', 'ch'),
('Syria', 'Damascus', 'sy'),
('Taiwan', 'Taipei', 'tw'),
('Tajikistan', 'Dushanbe', 'tj'),
('Tanzania', 'Dodoma', 'tz'),
('Thailand', 'Bangkok', 'th'),
('Timor-Leste', 'Dili', 'tl'),
('Togo', 'Lome', 'tg'),
('Tokelau', 'Fakaofo', 'tk'),
('Tonga', 'Nuku''alofa', 'to'),
('Trinidad and Tobago', 'Port of Spain', 'tt'),
('Tunisia', 'Tunis', 'tn'),
('Turkey', 'Ankara', 'tr'),
('Turkmenistan', 'Ashgabat', 'tm'),
('Turks and Caicos Islands', 'Cockburn Town', 'tc'),
('Tuvalu', 'Fongafale', 'tv'),
('Uganda', 'Kampala', 'ug'),
('Ukraine', 'Kiev', 'ua'),
('United Arab Emirates', 'Abu Dhabi', 'ae'),
('United Kingdom', 'London', 'gb'),
('United States', 'Washington DC', 'us'),
('Uruguay', 'Montevideo', 'uy'),
('Uzbekistan', 'Tashkent', 'uz'),
('Vanuatu', 'Port Vila', 'vu'),
('Venezuela', 'Caracas', 've'),
('Vietnam', 'Hanoi', 'vn'),
('US Virgin Islands', 'Charlotte Amalie', 'vi'),
('Wallis and Futuna', 'Mata-Utu', 'wf'),
('Western Sahara', 'Al aaiun', 'eh'),
('Yemen', 'San''a', 'ye'),
('Zambia', 'Lusaka', 'zm'),
('Zimbabwe', 'Harare', 'zw');

-- COMMIT;
