module AocInput

let IntArray (s: string) = s.Split(';') |> Array.map int

module Aoc2021 =
    let D1 =
        "188;192;196;198;199;202;208;225;231;219;226;232;265;267;268;287;288;296;297;303;321;325;327;332;334;343;348;351;354;355;357;358;359;361;389;397;395;367;368;370;372;356;366;370;373;376;390;389;391;402;413;419;426;427;450;452;456;457;463;462;457;463;450;452;456;455;464;460;461;476;477;486;492;495;512;513;534;535;545;549;555;559;564;539;548;555;556;558;560;567;566;565;566;567;569;572;581;582;583;575;591;602;606;607;608;610;614;616;620;630;635;634;633;665;666;680;685;678;694;697;698;702;704;705;711;721;719;720;731;730;731;733;742;747;767;764;761;763;757;763;766;767;773;790;791;793;780;788;808;837;842;853;855;857;858;859;861;870;872;875;868;870;866;867;872;873;869;846;865;868;869;870;872;875;878;881;888;903;907;908;914;918;919;922;918;921;918;924;927;921;927;928;929;930;936;945;954;980;982;993;994;1008;1010;1014;1016;1017;1022;1020;1023;1025;1021;1019;1027;1028;1031;1013;1014;1023;1024;1027;1028;1042;1051;1030;1035;1038;1020;1024;1019;983;988;1002;1003;1004;1001;1009;1016;1017;1024;1025;1034;1054;1057;1063;1064;1066;1087;1088;1091;1094;1095;1096;1105;1122;1124;1125;1123;1140;1130;1131;1138;1141;1143;1159;1163;1164;1193;1218;1220;1201;1200;1217;1218;1231;1230;1233;1241;1243;1245;1260;1262;1260;1286;1297;1298;1307;1313;1314;1313;1323;1324;1332;1333;1339;1357;1389;1390;1394;1396;1399;1392;1393;1394;1407;1408;1410;1422;1423;1424;1434;1435;1442;1462;1466;1467;1469;1470;1471;1485;1473;1474;1476;1486;1491;1496;1508;1538;1547;1554;1563;1574;1588;1594;1591;1594;1602;1606;1619;1625;1626;1636;1638;1641;1640;1646;1642;1655;1656;1650;1651;1657;1659;1657;1660;1675;1652;1638;1641;1644;1645;1647;1651;1653;1660;1662;1667;1668;1667;1668;1669;1673;1697;1701;1721;1726;1727;1723;1725;1732;1734;1733;1736;1757;1761;1772;1771;1789;1790;1794;1804;1806;1807;1811;1822;1812;1810;1812;1814;1791;1789;1781;1776;1781;1798;1802;1817;1820;1809;1807;1820;1825;1823;1835;1834;1835;1839;1843;1844;1824;1839;1844;1851;1853;1887;1895;1899;1904;1903;1901;1896;1903;1904;1909;1910;1915;1920;1932;1942;1944;1926;1951;1961;1962;1972;1975;1977;1984;1987;1993;2001;2003;2006;2013;2034;2046;2050;2058;2063;2060;2044;2050;2051;2045;2049;2078;2060;2063;2064;2065;2081;2082;2092;2098;2099;2107;2108;2134;2135;2157;2159;2158;2168;2167;2173;2179;2204;2208;2218;2221;2238;2234;2235;2236;2239;2243;2247;2248;2249;2264;2265;2266;2261;2262;2248;2256;2258;2270;2280;2284;2292;2293;2298;2299;2309;2332;2340;2341;2342;2343;2350;2353;2358;2359;2363;2365;2357;2359;2363;2370;2375;2374;2390;2384;2402;2405;2409;2412;2422;2428;2429;2432;2417;2410;2401;2418;2419;2420;2421;2417;2418;2422;2424;2436;2462;2471;2480;2478;2481;2505;2510;2518;2545;2546;2549;2564;2569;2577;2609;2605;2604;2614;2596;2613;2629;2631;2632;2635;2634;2663;2664;2678;2712;2689;2688;2697;2706;2708;2714;2715;2718;2739;2743;2745;2754;2752;2754;2794;2796;2797;2798;2801;2804;2807;2819;2838;2839;2840;2841;2842;2843;2848;2853;2883;2889;2905;2906;2912;2935;2925;2924;2957;2958;2980;2972;2973;2959;2964;2965;2976;2977;2978;2981;3000;3002;3009;2996;3000;2999;3001;3002;3008;3009;3011;3014;3015;3019;3037;3046;3048;3049;3050;3049;3050;3060;3056;3053;3065;3067;3068;3067;3073;3075;3076;3079;3086;3072;3076;3079;3103;3104;3117;3120;3111;3127;3128;3130;3129;3134;3137;3138;3140;3143;3159;3162;3188;3201;3204;3206;3216;3217;3196;3208;3210;3215;3216;3220;3236;3237;3227;3231;3249;3251;3255;3258;3261;3262;3271;3274;3270;3272;3281;3282;3303;3300;3317;3323;3358;3359;3360;3361;3364;3366;3370;3376;3377;3379;3380;3384;3385;3394;3401;3391;3392;3425;3414;3423;3428;3448;3454;3464;3465;3466;3469;3474;3476;3478;3488;3482;3483;3484;3486;3485;3498;3504;3505;3506;3514;3520;3523;3529;3534;3535;3537;3538;3545;3513;3515;3522;3527;3528;3537;3541;3542;3543;3548;3535;3537;3553;3590;3588;3596;3591;3598;3602;3606;3607;3608;3614;3612;3616;3618;3623;3624;3644;3645;3650;3651;3652;3654;3656;3660;3678;3680;3684;3685;3703;3709;3710;3717;3754;3755;3756;3727;3755;3761;3759;3765;3774;3775;3779;3786;3788;3800;3801;3802;3813;3841;3847;3856;3859;3866;3872;3869;3870;3890;3905;3906;3907;3908;3920;3921;3928;3939;3956;3967;3968;3974;3989;3995;3996;4000;4007;4015;4022;4019;4029;4030;4031;4040;4043;4044;4045;4054;4056;4075;4084;4085;4086;4088;4086;4093;4101;4111;4110;4111;4102;4103;4101;4102;4103;4110;4111;4121;4122;4142;4143;4142;4152;4155;4157;4132;4137;4141;4136;4138;4141;4143;4167;4169;4170;4171;4179;4180;4191;4194;4193;4181;4180;4181;4185;4191;4192;4194;4196;4200;4204;4208;4219;4223;4216;4219;4222;4228;4218;4224;4226;4248;4246;4249;4238;4237;4247;4263;4264;4268;4271;4277;4282;4283;4290;4291;4292;4300;4299;4300;4301;4302;4304;4305;4306;4310;4325;4327;4325;4338;4341;4343;4342;4343;4345;4346;4348;4362;4364;4365;4362;4370;4374;4377;4379;4385;4389;4407;4418;4422;4426;4429;4428;4450;4452;4445;4446;4454;4458;4476;4479;4486;4500;4498;4499;4498;4505;4508;4509;4518;4520;4523;4522;4530;4544;4545;4568;4572;4565;4582;4585;4586;4601;4587;4596;4612;4628;4629;4633;4634;4635;4640;4642;4641;4637;4638;4641;4637;4640;4641;4653;4658;4635;4644;4653;4654;4655;4681;4682;4681;4696;4689;4691;4697;4698;4708;4711;4713;4714;4725;4728;4731;4723;4725;4715;4724;4759;4762;4763;4764;4774;4777;4779;4780;4788;4787;4807;4828;4829;4830;4832;4833;4836;4830;4846;4827;4828;4831;4832;4837;4839;4842;4844;4845;4857;4835;4839;4840;4843;4841;4855;4856;4882;4891;4897;4890;4904;4912;4931;4932;4933;4946;4952;4953;4970;4974;4975;4969;4971;4972;4971;4972;4968;4983;4999;5001;5010;5012;5027;5025;5033;5036;5051;5032;5023;5024;5029;5043;5045;5049;5055;5071;5070;5072;5084;5085;5086;5092;5100;5099;5101;5113;5120;5111;5139;5146;5152;5149;5151;5128;5145;5132;5153;5181;5193;5197;5203;5236;5237;5235;5240;5241;5275;5270;5271;5287;5309;5313;5316;5317;5318;5319;5322;5323;5319;5322;5323;5326;5331;5323;5331;5326;5328;5329;5330;5331;5333;5334;5335;5329;5330;5332;5333;5334;5337;5338;5337;5338;5341;5340;5338;5339;5346;5347;5348;5334;5330;5331;5334;5342;5373;5374;5366;5367;5377;5381;5387;5414;5390;5394;5395;5378;5382;5385;5378;5387;5386;5387;5388;5389;5373;5374;5377;5386;5408;5411;5412;5414;5408;5426;5425;5458;5478;5479;5481;5482;5492;5496;5497;5502;5480;5481;5488;5503;5504;5470;5475;5476;5479;5480;5487;5491;5492;5491;5494;5496;5497;5495;5506;5508;5510;5509;5507;5515;5509;5510;5512;5528;5522;5530;5531;5544;5547;5548;5563;5571;5595;5597;5613;5634;5639;5648;5653;5656;5663;5675;5676;5671;5678;5681;5690;5711;5714;5721;5732;5737;5738;5760;5759;5769;5770;5771;5781;5783;5786;5784;5785;5787;5800;5802;5799;5800;5803;5808;5842;5838;5843;5844;5846;5855;5862;5865;5881;5904;5909;5910;5911;5914;5915;5920;5930;5956;5973;5981;5991;5993;6002;6024;6028;6031;6037;6031;6032;6035;6038;6065;6074;6076;6078;6079;6084;6086;6087;6076;6080;6068;6070;6081;6086;6097;6119;6125;6127;6125;6117;6124;6121;6124;6127;6134;6129;6131;6145;6147;6143;6144;6151;6150;6155;6156;6158;6159;6160;6172;6190;6191;6193;6192;6208;6225;6228;6234;6235;6236;6237;6242;6247;6248;6250;6241;6255;6257;6260;6261;6264;6263;6286;6265;6290;6295;6297;6322;6344;6359;6362;6371;6385;6388;6394;6395;6413;6425;6422;6423;6448;6450;6441;6444;6443;6446;6450;6468;6470;6473;6474;6480;6473;6474;6485;6484;6486;6498;6506;6518;6517;6535;6533;6559;6564;6565;6544;6554;6566;6567;6561;6574;6575;6609;6610;6633;6635;6639;6643;6645;6648;6652;6649;6615;6620;6633;6640;6641;6642;6645;6644;6648;6654;6656;6654;6664;6665;6668;6687;6692;6712;6713;6721;6710;6707;6706;6714;6718;6731;6742;6748;6749;6759;6726;6733;6736;6748;6749;6746;6743;6749;6752;6781;6777;6764;6763;6778;6781;6782;6807;6829;6831;6842;6850;6866;6867;6884;6891;6881;6883;6892;6905;6867;6859;6862;6863;6847;6848;6844;6845;6874;6894;6901;6894;6911;6935;6941;6948;6956;6955;6964;6969;6968;6969;6972;6974;6975;6983;6989;7009;7014;7016;7028;7024;7028;7029;7024;7042;7055;7059;7092;7095;7100;7109;7112;7110;7111;7110;7128;7129;7131;7133;7135;7163;7165;7175;7176;7177;7178;7188;7199;7181;7195;7200;7201;7203;7212;7224;7225;7234;7251;7252;7245;7246;7254;7256;7251;7252;7253;7254;7257;7256;7246;7245;7248;7261;7247;7246;7247;7254;7248;7256;7258;7259;7260;7261;7262;7277;7297;7300;7299;7301;7306;7314;7309;7313;7316;7318;7328;7329;7335;7323;7324;7331;7333;7334;7348;7330;7334;7335;7346;7348;7351;7356;7352;7356;7364;7372;7377;7378;7380;7387;7390;7388;7401;7403;7408;7427;7425;7429;7433;7457;7463;7474;7492;7493;7496;7495;7496;7502;7524;7532;7529;7535;7536;7544;7548;7549;7571;7585;7586;7589;7590;7595;7610;7611;7616;7621;7624;7659;7662;7635;7653;7639;7642;7643;7645;7658;7656;7665;7669;7668;7658;7686;7668;7667;7672;7675;7699;7703;7699;7710;7712;7738;7760;7759;7760;7762;7763;7770;7789;7791;7782;7779;7782;7779;7802;7795;7791;7808;7809;7821;7822;7829;7830;7853;7859;7860;7861;7864;7868;7852;7864;7865;7866;7863;7866;7862;7853;7863;7862;7864;7866;7868;7872;7874;7875;7895;7894;7896;7887;7891;7890;7891;7888;7889;7904;7905;7901;7922;7912;7911;7912;7911;7914;7915;7918;7923;7933;7924;7927;7930;7946;7948;7964;7966;7968;7972;7969;7968;7960;7968;7974;7975;7974;7953;7950;7944;7949;7955;7953;7954;7956;7959;7961;7962;7964;7968;7969;7985;7991;8006;8007;8008;8009;8029;8005;8006;8008;8015;8019;8012;8020;8021;8022;8028;8038;8037;8055;8065;8067;8061;8088;8095;8099;8100;8102;8105;8092;8093;8097;8102;8111;8112;8130;8141;8137;8140;8156;8157;8165;8168;8175;8189;8202;8205;8203;8208;8211;8223;8228;8229;8226;8242;8245;8246;8254;8257;8258;8259;8264;8269;8270;8271;8272;8259;8264;8267;8284;8285;8297;8299;8300;8301;8305;8306;8307;8308;8310;8311;8308;8312;8297;8302;8300;8303;8304;8309;8307;8316;8317;8310;8312;8317;8319;8327;8329;8340;8329;8339;8338;8339;8345;8335;8332;8348;8349;8350;8349;8351;8364;8365;8368;8371;8372;8384;8386;8383;8397;8428;8433;8449;8469;8472;8483;8491;8481;8483;8482;8483;8484;8486;8487;8497;8498;8499;8501;8509;8514;8517;8516;8518;8526;8528;8505;8509;8523;8524;8525;8526;8531;8518;8517;8520;8521;8542;8514;8517;8518;8528;8559;8562;8592;8617;8622;8632;8639;8640;8659;8660;8655;8665;8666;8661;8679;8687;8688;8676;8704;8711;8710"
    let D2 =
        "forward 4;down 9;forward 6;down 5;up 2;forward 5;forward 7;up 5;down 9;up 6;down 6;down 1;down 1;up 2;down 3;up 3;forward 8;forward 7;down 6;down 7;forward 6;forward 9;forward 7;up 9;down 4;down 6;down 5;down 9;forward 8;down 9;forward 9;forward 4;forward 4;up 3;up 8;down 9;down 8;down 4;forward 5;forward 4;up 6;forward 6;up 3;up 8;up 3;up 4;down 3;down 5;down 5;up 1;forward 9;down 4;forward 6;down 6;up 2;up 9;forward 1;forward 2;forward 7;down 6;up 6;forward 1;forward 7;down 7;forward 9;forward 4;forward 6;down 5;up 9;down 1;up 5;up 5;up 9;down 5;forward 7;down 1;up 9;down 7;forward 2;down 4;down 4;forward 8;forward 8;down 6;down 3;up 7;down 3;forward 9;down 7;forward 2;down 1;forward 5;up 9;down 2;up 2;down 3;up 7;forward 9;forward 7;down 4;down 5;up 3;down 3;down 5;forward 9;down 3;forward 9;down 3;up 9;down 5;forward 4;down 4;up 8;forward 7;up 1;down 2;forward 4;down 7;down 9;down 4;down 4;forward 6;down 7;down 2;down 1;forward 1;down 2;forward 1;down 7;forward 5;up 3;forward 6;up 9;down 3;down 3;down 9;forward 4;down 4;forward 9;forward 6;down 7;up 9;up 6;forward 4;down 5;forward 2;down 7;down 7;forward 4;forward 5;down 8;down 5;up 4;forward 7;up 8;down 8;forward 4;forward 5;down 6;down 1;down 1;down 9;forward 4;up 1;down 8;up 7;down 1;up 2;forward 4;down 7;down 7;down 2;forward 7;down 2;up 1;up 4;down 6;forward 5;forward 2;up 1;forward 2;forward 9;up 9;up 7;forward 9;down 8;up 5;down 6;down 6;up 8;down 1;forward 6;down 5;forward 2;down 9;down 9;up 4;forward 4;forward 2;forward 7;forward 3;down 1;forward 8;up 9;down 7;forward 9;forward 1;forward 5;up 6;down 6;forward 6;up 3;forward 9;down 3;forward 2;down 7;down 3;up 9;down 2;down 3;forward 5;down 9;forward 8;down 2;forward 1;down 9;down 7;forward 2;forward 6;forward 4;forward 5;down 5;down 1;forward 5;up 4;down 4;up 8;down 4;up 4;down 1;down 2;down 9;down 2;up 4;down 1;forward 2;forward 1;forward 9;down 5;up 4;up 1;forward 8;forward 6;forward 9;up 9;forward 4;forward 4;down 1;forward 6;forward 7;forward 3;up 5;up 7;down 1;forward 4;down 3;down 5;up 7;down 4;up 9;down 3;down 5;forward 7;forward 8;up 5;up 1;forward 3;up 8;forward 3;down 2;forward 1;forward 9;forward 1;down 2;forward 7;down 5;forward 6;down 9;up 9;forward 5;forward 7;forward 6;down 2;up 2;forward 3;forward 4;forward 3;down 5;forward 1;forward 2;forward 6;down 4;forward 2;forward 6;up 8;forward 2;up 4;forward 7;down 2;forward 1;forward 7;down 6;forward 4;down 3;down 2;down 2;forward 4;down 8;forward 6;forward 6;down 2;up 3;up 1;forward 1;down 5;down 2;forward 4;forward 7;forward 3;down 3;forward 9;down 1;down 7;forward 6;forward 1;up 6;forward 7;forward 1;down 5;down 4;forward 6;up 1;down 1;up 9;down 2;down 2;forward 3;up 4;down 5;down 5;down 3;down 6;up 8;forward 2;forward 2;down 6;down 1;up 4;up 1;down 5;up 4;up 2;forward 4;forward 6;forward 3;down 7;forward 8;up 5;forward 5;down 1;forward 2;forward 6;down 8;up 6;down 1;down 7;forward 4;forward 2;up 1;down 6;forward 3;forward 1;forward 5;forward 9;forward 9;down 4;forward 2;down 1;forward 1;forward 7;forward 5;down 9;down 8;down 1;down 6;down 1;up 7;down 3;forward 3;up 6;up 4;down 7;down 7;forward 6;up 7;down 7;forward 9;down 9;down 3;forward 6;forward 9;forward 1;down 4;forward 5;down 4;down 2;down 3;up 3;forward 9;forward 7;forward 5;down 5;forward 7;up 4;down 1;forward 3;down 3;forward 4;down 9;forward 2;down 5;down 1;forward 8;down 3;forward 7;up 1;down 3;forward 2;up 8;down 2;forward 4;forward 4;forward 4;down 5;up 6;down 3;forward 5;down 4;up 5;forward 1;forward 6;up 1;down 3;forward 2;forward 9;down 7;down 4;forward 5;up 3;up 6;up 1;forward 4;forward 1;forward 1;down 7;up 4;down 3;down 8;down 3;forward 8;forward 3;down 6;down 9;forward 3;forward 9;forward 7;down 8;down 6;down 4;forward 2;up 4;forward 8;down 1;forward 9;forward 1;down 9;forward 2;down 7;down 2;up 7;down 1;up 8;forward 8;down 7;forward 1;down 1;forward 3;forward 1;up 2;down 7;down 5;forward 5;down 8;forward 4;down 1;up 2;up 8;down 8;down 1;down 5;up 3;forward 3;forward 5;down 2;up 4;down 2;forward 7;forward 9;up 9;up 7;forward 1;up 4;forward 3;up 5;forward 9;forward 9;forward 6;forward 2;down 7;forward 8;forward 4;forward 7;down 8;down 5;down 6;forward 6;down 4;down 1;down 9;down 1;forward 3;forward 5;down 6;down 7;down 9;down 8;down 4;up 5;forward 7;down 9;forward 6;down 7;forward 5;down 5;forward 1;down 5;down 3;up 9;up 3;forward 2;up 9;forward 6;down 1;down 5;down 9;down 4;up 6;forward 9;down 4;down 9;down 5;down 8;down 5;down 4;up 5;down 8;up 8;forward 5;down 9;forward 2;up 2;down 6;forward 2;forward 4;forward 6;down 6;down 1;forward 8;down 5;down 5;forward 2;down 7;down 5;down 6;down 9;forward 4;up 9;down 3;down 7;forward 3;down 5;up 1;forward 5;up 2;down 2;forward 2;up 3;up 6;forward 2;forward 7;down 8;forward 8;forward 7;forward 6;down 5;down 6;down 6;down 9;up 5;down 3;up 1;up 9;up 5;down 4;down 4;down 8;forward 8;up 5;down 9;forward 1;up 1;forward 2;down 9;forward 5;up 9;forward 7;down 7;down 5;up 1;up 2;down 8;down 7;up 4;forward 9;down 4;up 8;down 5;down 1;forward 9;down 6;up 8;down 6;forward 7;up 6;up 5;forward 2;up 7;forward 7;forward 5;down 1;forward 9;down 8;forward 9;down 3;down 3;forward 9;up 1;down 2;forward 9;down 7;forward 4;forward 3;forward 4;down 5;forward 9;forward 9;down 5;forward 4;down 5;down 2;down 6;forward 5;forward 8;forward 6;up 9;down 9;forward 7;down 6;down 7;down 4;forward 1;forward 3;forward 6;forward 4;forward 3;forward 4;down 1;forward 2;forward 3;forward 9;up 8;forward 6;down 1;up 5;down 1;down 4;down 7;down 5;down 9;down 2;down 9;forward 2;down 2;up 5;forward 2;forward 3;forward 5;up 8;up 1;down 9;forward 2;down 4;down 9;down 6;down 5;down 8;forward 3;forward 8;forward 7;up 3;up 5;down 9;down 5;up 6;forward 4;forward 4;forward 4;down 9;down 2;down 7;down 1;down 2;down 4;forward 7;down 9;forward 4;forward 5;up 5;forward 4;forward 9;forward 1;forward 5;down 3;forward 1;forward 5;up 9;down 7;forward 7;forward 6;down 2;down 3;forward 9;down 1;forward 4;forward 9;up 7;forward 7;down 5;forward 9;forward 2;up 3;down 3;down 7;down 5;up 7;up 9;up 7;forward 3;forward 3;forward 8;up 9;forward 8;forward 9;forward 4;down 2;forward 7;down 6;up 3;up 9;forward 8;forward 2;down 9;down 7;forward 1;up 4;up 7;forward 2;up 4;forward 4;up 1;forward 3;down 7;forward 5;down 4;forward 2;forward 7;up 4;down 1;down 6;forward 1;forward 9;up 6;forward 7;forward 7;down 8;forward 7;down 8;down 9;up 3;forward 3;forward 3;down 8;up 2;down 2;down 4;up 3;down 3;forward 7;down 4;up 8;down 9;down 9;up 7;down 1;forward 2;up 1;down 3;up 9;down 6;up 2;forward 6;up 8;up 1;down 6;down 1;up 6;up 4;up 2;forward 6;down 6;down 1;forward 7;up 9;up 1;forward 4;forward 5;up 6;forward 9;down 1;down 9;down 3;down 7;forward 7;down 1;down 4;forward 6;down 5;up 4;forward 9;up 5;down 1;down 2;down 2;up 4;forward 1;forward 3;down 7;forward 4;down 4;down 8;down 5;forward 3;up 4;forward 5;down 2;down 4;down 4;down 1;forward 2;forward 1;forward 8;forward 4;up 4;down 9;up 6;forward 9;up 5;down 5;forward 3;up 1;forward 7;down 4;forward 7;down 9;up 8;down 5;forward 1;down 5;down 8;forward 3;up 6;forward 3;up 7;forward 6;forward 9;up 1;down 3;down 9;up 4;up 6;forward 5;down 6;down 3;down 4;up 1;forward 5;down 5;down 2;forward 6;down 8;down 3;up 8;forward 5;forward 6;down 6;down 6;down 6;forward 7;up 4;forward 7;up 4;down 2;forward 4;forward 2;down 6;up 1;down 1;down 4;up 8;down 6;forward 3;forward 6;down 6;forward 5;down 4;up 2;up 3;down 3;up 1;forward 2;up 1;forward 4;up 5;up 2;down 7;forward 3;up 2;forward 5;down 1;down 3;down 2;forward 5;down 1;up 5;forward 4;down 7;up 8;up 3;down 7;down 7;forward 9;forward 1;up 6;down 4;down 7;forward 1;down 4;forward 9;up 1;forward 3;down 1;up 3;down 6;down 8;down 6;forward 6;forward 6;up 2;down 8;forward 5"

module Aoc2019 =
    let D8 =
        System.IO.File.ReadLines(__SOURCE_DIRECTORY__ + "/Aoc2019-Day8.txt")
        |> Seq.map (fun x -> x.ToCharArray())
        |> Seq.concat
        |> Seq.map (fun x -> (int x) - (int '0'))

    let D7 =
        "3,8,1001,8,10,8,105,1,0,0,21,46,59,72,93,110,191,272,353,434,99999,3,9,101,4,9,9,1002,9,3,9,1001,9,5,9,102,2,9,9,1001,9,5,9,4,9,99,3,9,1002,9,5,9,1001,9,5,9,4,9,99,3,9,101,4,9,9,1002,9,4,9,4,9,99,3,9,102,3,9,9,101,3,9,9,1002,9,2,9,1001,9,5,9,4,9,99,3,9,1001,9,2,9,102,4,9,9,101,2,9,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,101,2,9,9,4,9,99,3,9,101,2,9,9,4,9,3,9,101,2,9,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,101,1,9,9,4,9,99,3,9,101,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,1,9,4,9,3,9,101,2,9,9,4,9,99,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,1,9,4,9,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,99,3,9,1001,9,1,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,1,9,4,9,99"

    let D6 =
        System.IO.File.ReadLines(__SOURCE_DIRECTORY__ + "/Aoc2019-Day6.txt")
        |> Seq.map (fun x ->
            let y = x.Split(")")
            y.[0], y.[1])


    let D5 =
        "3,225,1,225,6,6,1100,1,238,225,104,0,101,71,150,224,101,-123,224,224,4,224,102,8,223,223,101,2,224,224,1,224,223,223,2,205,209,224,1001,224,-3403,224,4,224,1002,223,8,223,101,1,224,224,1,223,224,223,1101,55,24,224,1001,224,-79,224,4,224,1002,223,8,223,101,1,224,224,1,223,224,223,1,153,218,224,1001,224,-109,224,4,224,1002,223,8,223,101,5,224,224,1,224,223,223,1002,201,72,224,1001,224,-2088,224,4,224,102,8,223,223,101,3,224,224,1,223,224,223,1102,70,29,225,102,5,214,224,101,-250,224,224,4,224,1002,223,8,223,1001,224,3,224,1,223,224,223,1101,12,52,225,1101,60,71,225,1001,123,41,224,1001,224,-111,224,4,224,102,8,223,223,1001,224,2,224,1,223,224,223,1102,78,66,224,1001,224,-5148,224,4,224,1002,223,8,223,1001,224,2,224,1,223,224,223,1101,29,77,225,1102,41,67,225,1102,83,32,225,1101,93,50,225,1102,53,49,225,4,223,99,0,0,0,677,0,0,0,0,0,0,0,0,0,0,0,1105,0,99999,1105,227,247,1105,1,99999,1005,227,99999,1005,0,256,1105,1,99999,1106,227,99999,1106,0,265,1105,1,99999,1006,0,99999,1006,227,274,1105,1,99999,1105,1,280,1105,1,99999,1,225,225,225,1101,294,0,0,105,1,0,1105,1,99999,1106,0,300,1105,1,99999,1,225,225,225,1101,314,0,0,106,0,0,1105,1,99999,1107,677,677,224,1002,223,2,223,1005,224,329,101,1,223,223,7,677,677,224,1002,223,2,223,1005,224,344,1001,223,1,223,7,226,677,224,102,2,223,223,1006,224,359,101,1,223,223,1108,226,226,224,1002,223,2,223,1005,224,374,1001,223,1,223,8,226,677,224,1002,223,2,223,1006,224,389,1001,223,1,223,1108,226,677,224,1002,223,2,223,1006,224,404,101,1,223,223,1107,677,226,224,102,2,223,223,1006,224,419,101,1,223,223,1007,677,677,224,1002,223,2,223,1005,224,434,101,1,223,223,7,677,226,224,102,2,223,223,1006,224,449,1001,223,1,223,1008,226,677,224,1002,223,2,223,1006,224,464,101,1,223,223,8,677,677,224,1002,223,2,223,1006,224,479,101,1,223,223,108,226,226,224,102,2,223,223,1005,224,494,101,1,223,223,1107,226,677,224,1002,223,2,223,1006,224,509,101,1,223,223,107,226,226,224,1002,223,2,223,1006,224,524,1001,223,1,223,107,677,677,224,1002,223,2,223,1005,224,539,101,1,223,223,1007,226,226,224,102,2,223,223,1006,224,554,101,1,223,223,108,677,677,224,102,2,223,223,1005,224,569,101,1,223,223,107,677,226,224,102,2,223,223,1005,224,584,101,1,223,223,1008,226,226,224,102,2,223,223,1006,224,599,101,1,223,223,1108,677,226,224,1002,223,2,223,1006,224,614,101,1,223,223,8,677,226,224,102,2,223,223,1005,224,629,1001,223,1,223,1008,677,677,224,102,2,223,223,1006,224,644,101,1,223,223,1007,226,677,224,102,2,223,223,1005,224,659,101,1,223,223,108,226,677,224,102,2,223,223,1006,224,674,101,1,223,223,4,223,99,226"

    let D4 =
        "3,225,1,225,6,6,1100,1,238,225,104,0,101,71,150,224,101,-123,224,224,4,224,102,8,223,223,101,2,224,224,1,224,223,223,2,205,209,224,1001,224,-3403,224,4,224,1002,223,8,223,101,1,224,224,1,223,224,223,1101,55,24,224,1001,224,-79,224,4,224,1002,223,8,223,101,1,224,224,1,223,224,223,1,153,218,224,1001,224,-109,224,4,224,1002,223,8,223,101,5,224,224,1,224,223,223,1002,201,72,224,1001,224,-2088,224,4,224,102,8,223,223,101,3,224,224,1,223,224,223,1102,70,29,225,102,5,214,224,101,-250,224,224,4,224,1002,223,8,223,1001,224,3,224,1,223,224,223,1101,12,52,225,1101,60,71,225,1001,123,41,224,1001,224,-111,224,4,224,102,8,223,223,1001,224,2,224,1,223,224,223,1102,78,66,224,1001,224,-5148,224,4,224,1002,223,8,223,1001,224,2,224,1,223,224,223,1101,29,77,225,1102,41,67,225,1102,83,32,225,1101,93,50,225,1102,53,49,225,4,223,99,0,0,0,677,0,0,0,0,0,0,0,0,0,0,0,1105,0,99999,1105,227,247,1105,1,99999,1005,227,99999,1005,0,256,1105,1,99999,1106,227,99999,1106,0,265,1105,1,99999,1006,0,99999,1006,227,274,1105,1,99999,1105,1,280,1105,1,99999,1,225,225,225,1101,294,0,0,105,1,0,1105,1,99999,1106,0,300,1105,1,99999,1,225,225,225,1101,314,0,0,106,0,0,1105,1,99999,1107,677,677,224,1002,223,2,223,1005,224,329,101,1,223,223,7,677,677,224,1002,223,2,223,1005,224,344,1001,223,1,223,7,226,677,224,102,2,223,223,1006,224,359,101,1,223,223,1108,226,226,224,1002,223,2,223,1005,224,374,1001,223,1,223,8,226,677,224,1002,223,2,223,1006,224,389,1001,223,1,223,1108,226,677,224,1002,223,2,223,1006,224,404,101,1,223,223,1107,677,226,224,102,2,223,223,1006,224,419,101,1,223,223,1007,677,677,224,1002,223,2,223,1005,224,434,101,1,223,223,7,677,226,224,102,2,223,223,1006,224,449,1001,223,1,223,1008,226,677,224,1002,223,2,223,1006,224,464,101,1,223,223,8,677,677,224,1002,223,2,223,1006,224,479,101,1,223,223,108,226,226,224,102,2,223,223,1005,224,494,101,1,223,223,1107,226,677,224,1002,223,2,223,1006,224,509,101,1,223,223,107,226,226,224,1002,223,2,223,1006,224,524,1001,223,1,223,107,677,677,224,1002,223,2,223,1005,224,539,101,1,223,223,1007,226,226,224,102,2,223,223,1006,224,554,101,1,223,223,108,677,677,224,102,2,223,223,1005,224,569,101,1,223,223,107,677,226,224,102,2,223,223,1005,224,584,101,1,223,223,1008,226,226,224,102,2,223,223,1006,224,599,101,1,223,223,1108,677,226,224,1002,223,2,223,1006,224,614,101,1,223,223,8,677,226,224,102,2,223,223,1005,224,629,1001,223,1,223,1008,677,677,224,102,2,223,223,1006,224,644,101,1,223,223,1007,226,677,224,102,2,223,223,1005,224,659,101,1,223,223,108,226,677,224,102,2,223,223,1006,224,674,101,1,223,223,4,223,99,226"

    let D3 =
        [| "R1004,D53,L10,U126,R130,U533,R48,D185,L768,U786,L445,U694,L659,D237,R432,U147,R590,U200,R878,D970,L308,D134,R617,U431,L631,D548,L300,D509,R660,U698,L958,U170,R572,U514,R387,D385,L670,D374,R898,U870,L545,D262,L699,D110,R58,D84,R77,D58,L891,U9,R320,D914,L161,D148,L266,D334,R442,D855,R349,D618,R272,U514,R584,D269,R608,U542,L335,U855,L646,D678,R720,U325,L792,U60,L828,D915,L487,D253,L911,U907,R392,D981,R965,D725,R308,D574,L997,D332,L927,D855,R122,D5,L875,D336,L395,U697,R806,U420,R718,D575,L824,U397,L308,D988,L855,U332,R838,U853,L91,U778,R265,U549,L847,D665,L804,D768,L736,D201,L825,U87,L747,D375,L162,U336,R375,U754,R468,U507,R256,D107,L79,U871,L155,D667,L448,D847,L193,U263,R154,U859,R696,D222,R189,D307,R332,U522,L345,D961,L161,U274,L122,U931,L812,D852,R906,D269,R612,D723,L304,U944,R64,D20,R401,D260,L95,U278,R128,U637,L554,D650,L116,D720,R12,D434,R514,U379,L899,D359,R815,D843,L994,U775,R63,D942,R655,D91,L236,U175,L813,D572,R520,U812,L657,D935,L886,D178,R618,U260,R7,D953,L158,D471,R309,D858,R25,U746,R40,U832,L544,D311,R122,D224,L281,D699,R147,D310,R659,D662,L990,U160,L969,D335,L923,U201,R336,D643,R226,D91,R88,U350,L303,U20,L157,U987,L305,U766,R253,D790,R977,U482,R283,U793,R785,D799,L511,D757,L689,D841,L233,U742,L551,D466,R66,U579,L18,U838,R554,D143,L996,U557,L783,D799,R36,D563,L244,U440,L8,D945,L346,D747,L769,U661,L485,U965,L569,U952,R57,U773,L267,U453,R424,U66,R763,U105,R285,D870,L179,U548,L46,U914,L251,U194,L559,U736,R768,D917,R617,D55,R185,D464,L244 "
           "L1005,D527,R864,D622,R482,D647,R29,U459,R430,D942,R550,D163,L898,U890,L271,D216,L52,U731,R715,U925,L614,U19,R687,D832,L381,U192,L293,D946,L642,D2,L124,U66,R492,U281,R181,U624,R294,U767,R443,U424,R241,D225,R432,D419,L647,U290,L647,D985,L694,D777,L382,D231,R809,D467,L917,D217,R422,U490,L873,D537,R176,U856,L944,D875,L485,D49,R333,D220,L354,U789,R256,D73,R905,U146,R798,D429,R111,D585,L275,D471,R220,D619,L680,U757,R580,U497,L620,U753,R58,U574,L882,U484,R297,D899,L95,D186,R619,D622,R65,U714,L402,U950,R647,D60,L659,U101,L917,D736,L531,U398,R26,U134,R837,U294,R364,D55,R254,D999,R868,U978,R434,U661,R362,D158,L50,D576,L146,D249,L562,D433,R206,D376,L650,U285,L427,D406,L526,D597,R557,U554,L463,D157,L811,U961,R648,D184,L962,U695,R138,U661,L999,U806,L413,U54,L865,U931,L319,U235,L794,D12,L456,D918,L456,U214,L739,D772,R90,D478,R23,D658,R919,D990,L307,D534,L40,D324,L4,U805,L605,U534,R727,U452,R733,D416,L451,U598,R215,D545,L563,D222,L295,D669,R706,U11,R44,D392,L518,D437,L634,U874,L641,U240,L11,D279,L153,U601,L238,U924,L292,D406,L360,D203,R874,D506,R806,U9,R713,D891,L587,U538,L867,D637,R889,U186,R728,D672,R573,U461,R222,D703,R178,U336,L896,D924,L445,D365,L648,U3,L734,U959,R344,U314,R331,D929,L364,D937,L896,D191,R218,U256,L975,D506,R510,D392,R878,U896,L177,U4,R516,D873,R57,D530,R140,D827,L263,U848,L88,U309,L801,U670,R874,D358,L49,D259,L188,U419,R705,D498,R496,U576,R808,D959,L861,U437,L618,D112,R725,D546,R338,U879,R522,U892,R230,D367,R901,D737,L942,D689,R976,D369,R157" |]

    let D2 =
        "1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,10,19,2,9,19,23,1,9,23,27,2,27,9,31,1,31,5,35,2,35,9,39,1,39,10,43,2,43,13,47,1,47,6,51,2,51,10,55,1,9,55,59,2,6,59,63,1,63,6,67,1,67,10,71,1,71,10,75,2,9,75,79,1,5,79,83,2,9,83,87,1,87,9,91,2,91,13,95,1,95,9,99,1,99,6,103,2,103,6,107,1,107,5,111,1,13,111,115,2,115,6,119,1,119,5,123,1,2,123,127,1,6,127,0,99,2,14,0,0"

    let D1 =
        [ 101005
          139223
          112833
          70247
          131775
          106730
          118388
          138683
          80439
          71060
          120862
          67201
          70617
          79783
          114813
          77907
          78814
          107515
          113507
          81865
          88130
          75120
          66588
          56023
          98080
          128472
          96031
          118960
          54069
          112000
          62979
          105518
          73342
          52270
          128841
          68267
          70789
          94792
          100738
          102331
          83082
          77124
          97360
          86165
          66120
          139042
          50390
          105308
          94607
          58225
          77894
          118906
          127277
          101446
          58897
          93876
          53312
          117154
          77448
          62041
          99069
          87375
          134854
          108561
          126406
          53809
          90760
          121650
          79573
          134734
          148021
          84263
          54390
          132706
          148794
          67302
          146885
          76108
          76270
          54548
          146920
          145282
          129509
          144139
          141713
          62547
          149898
          96746
          83583
          107758
          63912
          142036
          112281
          91775
          75809
          82250
          144667
          140140
          98276
          103479 ]
