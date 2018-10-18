﻿using btc.Models;
using btc.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Market> market = new List<Market>();
            decimal lucro=0;
            decimal porcentagem = 0;
            //string[] moedas = { "eth", "xrp", "bch", "eos", "xlm", "ltc", "usdt", "ada", "xmr", "miota", "trx", "dash", "bnb", "neo", "etc", "xem", "xtz", "vet", "doge", "zec", "omg", "btg", "bcn", "mkr", "lsk", "ont", "zrx", "qtum", "dcr", "bcd", "bts", "nano", "zil", "sc", "dgb", "icx", "ae", "steem", "xvg", "waves", "btm", "npxs", "bat", "etp", "etn", "strat", "gnt", "rep", "hot", "snt", "xet", "kmd", "ppt", "cnx", "tusd", "rdd", "ardr", "wtc", "mith", "link", "wan", "kcs", "iost", "maid", "hc", "moac", "vulc", "aion", "aoa", "elf", "ht", "bnt", "dcn", "rhoc", "drop", "gxs", "mona", "mana", "fun", "zen", "noah", "nas", "qash", "dgd", "cmt", "ark", "mco", "pay", "nxt", "pivx", "lrc", "wax", "theta", "powr", "xin", "loom", "ela", "nexo", "gas", "dai", "xzc", "drgn", "poly", "gvt", "ocn", "ctxc", "kin", "sys", "knc", "sub", "btcp", "iq", "nuls", "nec", "nxs", "eng", "fct", "bco", "wicc", "emc", "cvc", "bix", "qkc", "enj", "tel", "salt", "grs", "dent", "r", "icn", "dgtx", "ddd", "storm", "gto", "sky", "lky", "veri", "storj", "gbyte", "wgr", "man", "req", "brd", "cennz", "san", "rlc", "cnd", "vtc", "hpb", "ignis", "edr", "rvn", "bhpc", "ten", "jnt", "gcr", "zip", "c20", "fsn", "ode", "plr", "edo", "smt", "soc", "rdn", "ncash", "nebl", "true", "apl", "tky", "ethos", "crpt", "bft", "stq", "dta", "data", "credo", "block", "ppc", "gno", "xdn", "blz", "nmc", "poe", "nav", "agi", "cs", "ruff", "rnt", "bitcny", "smart", "xwc", "act", "bto", "mgo", "abt", "qsp", "tomo", "ant", "gtc", "tnb", "tpay", "nty", "bci", "go", "mds", "vee", "ubq", "part", "btcd", "apis", "mft", "mtl", "amb", "cvt", "iht", "bos", "gnx", "snm", "burst", "cosm", "srn", "ren", "lkk", "iotx", "spank", "gbc", "ost", "safex", "zcl", "dig", "sls", "bay", "auto", "xas", "poa", "rkt", "itc", "atx", "lend", "ngc", "sphtx", "lym", "fxt", "tmc", "edg", "utk", "chat", "bax", "eca", "medx", "uno", "tio", "pzm", "cnn", "sngls", "xpm", "vibe", "emc2", "key", "sbd", "lcc", "pst", "dnt", "mod", "adx", "vite", "rth", "via", "evr", "ion", "kick", "rcn", "eurs", "seele", "dew", "dbc", "wpr", "pai", "loki", "eosdac", "horus", "kan", "ttc", "dtr", "ast", "wings", "skb", "game", "xby", "hydro", "pre", "tct", "tnt", "mtc", "qlc", "cloak", "nix", "cpc", "cpt", "btx", "pma", "lba", "mnx", "bwt", "lyl", "met", "xyo", "utt", "leo", "sxdt", "pasc", "mobi", "neu", "lgo", "ttu", "phx", "appc", "nkn", "rfr", "linda", "cdt", "qrl", "ins", "dcc", "ppp", "zpt", "bitusd", "wabi", "cbc", "fair", "$pac", "cov", "dax", "hvn", "ink", "nlg", "imt", "xlq", "dpy", "scrl", "csc", "aura", "swftc", "fuel", "med", "cob", "mlm", "bbr", "msp", "xsn", "repo", "soar", "trac", "dct", "int", "dbet", "arb", "edr", "bwk", "lbc", "cfi", "yoyow", "btn", "tkn", "gin", "aeon", "ftc", "box", "dmt", "mvl", "mda", "daps", "xto", "bitb", "vitae", "iog", "tern", "swm", "trig", "bitg", "scr", "qbit", "atn", "utnp", "opti", "nvc", "spc", "qnt", "crw", "html", "adt", "exc", "edn", "xcp", "ecc", "dock", "cpx", "xrl", "shift", "lun", "slt", "ekt", "nanj", "vib", "tube", "coss", "bbk", "evx", "hot", "zcn", "rvr", "zrc", "dim", "mwat", "bcpt", "yee", "mer", "zco", "pepecash", "phr", "bbc", "grid", "mth", "la", "thc", "let", "chsb", "hlc", "dov", "pro", "dime", "cas", "zpr", "rise", "mot", "datx", "colx", "moc", "plbt", "flash", "prl", "bznt", "pura", "tix", "dadi", "spd", "b2b", "mln", "bet", "blk", "skm", "fota", "bkx", "clam", "bmc", "hmc", "pbt", "ebc", "dlt", "bis", "hav", "rock2", "stx", "dag", "1st", "dmd", "nmr", "fnkos", "xspec", "dat", "pot", "zsc", "hmq", "ivy", "bca", "ecob", "npw", "wab", "ucash", "nct", "bpt", "qun", "onion", "rmc", "amp", "sen", "tau", "mgd", "blt", "evn", "arn", "fti", "abl", "xdce", "csno", "dev", "get", "ppy", "ioc", "incnt", "pat", "oct", "lnc", "rmt", "xmy", "oax", "dacs", "xel", "lcs", "grc", "npx", "banca", "cag", "ugc", "rby", "tfd", "ukg", "ac", "pra", "upp", "card", "tmt", "rem", "xpa", "capp", "atmi", "axpr", "clo", "stk", "mozo", "btt", "cv", "loc", "pnd", "aidoc", "ttt", "up", "myst", "swth", "mtn", "omni", "ut", "lgs", "drt", "music", "gem", "hpc", "nyc", "tic", "xp", "snc", "rads", "boxx", "lpc", "xaur", "egt", "ero", "xst", "orme", "bwx", "flo", "mue", "krm", "grft", "elec", "mrk", "omx", "dxt", "dx", "gup", "bq", "gam", "lux", "gsc", "uuu", "tnc", "sent", "hst", "brm", "vex", "sem", "ntk", "avinoc", "xes", "taas", "cbc", "vrc", "ret", "srcoin", "dice", "adst", "hkn", "vips", "ac3", "dtb", "bbn", "apx", "czr", "ssc", "pch", "mint", "bmx", "slr", "anc", "gen", "nlc2", "noku", "cccx", "time", "cvn", "mdt", "deb", "aur", "xsh", "ecom", "tsl", "polis", "wct", "got", "xnk", "ixt", "exy", "rmesh", "nbc", "bsd", "mas", "exrn", "chp", "bob", "bz", "ali", "exp", "olt", "dot", "vin", "lif", "etk", "toa", "coval", "pirl", "rte", "dna", "note", "esp", "idh", "mrph", "xlr", "air", "xhv", "thr", "prg", "adb", "ift", "tfl", "rntb", "ssp", "sic", "rvt", "pkc", "aac", "sntr", "nio", "sib", "seq", "bot", "ptoy", "acat", "rlx", "shnd", "zmn", "sxut", "fdz", "nbai", "tips", "qrk", "ole", "ok", "aph", "sta", "otn", "divx", "cxo", "qbt", "nim", "lev", "dyn", "food", "dgx", "dero", "trc", "crbt", "hb", "golos", "gbx", "dav", "bez", "fork", "mvp", "aid", "care", "ucn", "senc", "myb", "lmc", "art", "abyss", "gcc", "swt", "ship", "elix", "mic", "red", "cure", "cofi", "ipl", "aby", "ceek", "au", "lnd", "shp", "hbt", "alx", "her", "bcy", "efx", "soul", "eko", "scl", "ava", "dth", "ss", "ledu", "pink", "can", "svd", "dbix", "flixx", "1wo", "xmx", "x8x", "avt", "ubt", "alis", "yoc", "knt", "tks", "sense", "flp", "xra", "cbt", "face", "cpc", "xsd", "uqc", "fldc", "xtl", "enrg", "cln", "real", "evc", "2give", "trst", "nper", "hdg", "ftx", "tgt", "mtx", "geo", "pal", "instar", "plu", "berry", "adh", "neos", "idxm", "xap", "inxt", "vzt", "ftt", "oxy", "eve", "bdg", "atm", "ctc", "pareto", "icos", "hbz", "pcl", "soniq", "erc", "brx", "ait", "fluz", "cmct", "1337", "msr", "btcz", "fcn", "amlt", "hxx", "astro", "nsd", "ptc", "bnty", "zap", "peng", "poll", "mtc", "trf", "vme", "rebl", "gld", "zel", "pkt", "frec", "life", "snov", "dagt", "iop", "own", "bee", "sprts", "pix", "coin", "qwark", "blu", "payx", "dow", "nkc", "ncc", "j8t", "kwatt", "rating", "onl", "gat", "nxc", "cpy", "nrg", "c2c", "sphr", "wsx", "posw", "obits", "blue", "betr", "like", "cbx", "kb3", "zoi", "0xbtc", "ind", "zeph", "latx", "tx", "zla", "max", "sumo", "excl", "send", "etbs", "gpkr", "ebst", "atl", "seth", "atmos", "spx", "ors", "ipsx", "net", "ett", "rct", "ary", "ert", "gla", "cpay", "phi", "usnbt", "cst", "heat", "vrm", "cat", "zeit", "dope", "iflt", "xhi", "dnr", "spf", "shl", "sig", "hgt", "tie", "ufr", "play", "tes", "monk", "lala", "tac", "engt", "wish", "pbl", "tig", "ong", "zest", "nrve", "nobl", "spr", "fdx", "42", "prix", "cann", "unit", "trtt", "bitx", "kore", "xclr", "synx", "star", "bela", "huc", "carbon", "lwf", "zipt", "chips", "evn", "aro", "good", "efl", "flot", "mrt", "cdm", "hqx", "ccrb", "mitx", "rc", "buzz", "nusd", "spd", "ufo", "kind", "ldoge", "krb", "pfr", "808", "meme", "hwc", "chx", "hyp", "opt", "put", "uni", "sms", "medic", "arg", "vit", "trtl", "mbi", "gene", "voise", "smoke", "mntp", "purex", "sexc", "auc", "atb", "wrc", "vulc", "hac", "efyt", "hero", "loci", "ebtc", "ace", "lynx", "ecn", "skin", "egc", "metm", "oot", "cred", "zxc", "cyfm", "bpl", "xpd", "ntrn", "bits", "btk", "trak", "navi", "krl", "tgame", "aaa", "ndc", "web", "chc", "gcn", "mvc", "zer", "aux", "brk", "fkx", "prj", "alt", "xsg", "fgc", "pho", "cat", "ccl", "dit", "bio", "dar", "ryo", "adc", "horse", "xbc", "nlx", "talao", "thrt", "dan", "i0c", "aht", "well", "ing", "tcc", "cfun", "toll", "xmg", "kek", "fid", "pipl", "aix", "xcg", "ldc", "sgr", "shard", "day", "inv", "rupx", "view", "tbx", "tag", "xbi", "hand", "ixc", "xcn", "fsbt", "eqt", "bon", "fyp", "trust", "ore", "kobo", "aka", "fnd", "hire", "tka", "crb", "getx", "nsr", "unic", "bouts", "klks", "ella", "pmnt", "amm", "spn", "stac", "ping", "flt", "tzc", "bbo", "ref", "vsl", "pop", "acre", "jot", "aog", "live", "xun", "brit", "bbp", "orb", "mfg", "opc", "vsx", "qno", "ptt", "rgs", "pylnt", "hush", "rex", "dtx", "cl", "adi", "cymt", "wsd", "bun", "xnn", "rain", "fjc", "crc", "mxt", "bir", "zet", "vikky", "smly", "xmcc", "crea", "rup", "gic", "adz", "xbp", "ocl", "for", "xcash", "log", "cmpco", "ezt", "aib", "dgc", "dcy", "sgn", "kln", "wand", "snrg", "inn", "eql", "dor", "moto", "byc", "evi", "gmt", "cdn", "stak", "sxc", "btdx", "amn", "unb", "wdc", "pkg", "crave", "riya", "apr", "bit", "sur", "hur", "zny", "kndc", "more", "ftxt", "egem", "foxt", "ben", "bti", "lnc", "mao", "zinc", "maza", "ntk", "viu", "tse", "bria", "mage", "dml", "zeni", "dp", "troll", "mag", "ic", "hnc", "trk", "xgox", "hodl", "nka", "utc", "stu", "bitbtc", "team", "vivo", "lana", "cash", "piggy", "skc", "xptx", "pcn", "itt", "bitsilver", "grwi", "beet", "dsh", "arc", "bbi", "dem", "btxc", "sct", "el", "btw", "moin", "strc", "esz", "hbn", "onx", "frst", "btb", "btm", "ttc", "ely", "jet", "pxc", "drpu", "ele", "mci", "bro", "ebch", "rtb", "edrc", "btwty", "ig", "acc", "nobs", "manna", "kbr", "sgp", "bits", "bitgold", "acc", "linx", "epy", "bnc0", "gnr", "cdx", "exmr", "bmh", "bta", "bnd", "asafe2", "q2c", "proc", "cato", "opal", "trump", "rns", "btrn", "blc", "v", "fst", "bbs", "ft", "mtnc", "cmm", "knt", "cstl", "bstn", "fyn", "nbr", "dix", "flik", "ieth", "priv", "bnn", "ori", "put", "croat", "insn", "dgpt", "xxx", "bcf", "tdx", "sdrn", "bdl", "xdna", "sss", "start", "tek", "mne", "btcs", "etg", "saga", "jc", "btcr", "dft", "crm", "sol", "dtem", "mec", "rlt", "ebet", "funk", "irl", "ecash", "iti", "ctl", "nyan", "tri", "talk", "net", "gun", "xjo", "toto", "tns", "odn", "ucom", "rbies", "blz", "gap", "hal", "uis", "netko", "xpy", "zcr", "cco", "caz", "xra", "opcx", "mac", "cfl", "lobs", "vot", "super", "nms", "trct", "slg", "ats", "rbt", "mbrs", "btcn", "pr", "bunny", "whl", "unify", "arct", "kush", "tsc", "qvt", "bsm", "rec", "biteur", "yup", "vidz", "bws", "ctx", "evil", "icoo", "vrs", "grmd", "dmb", "occ", "ked", "smc", "bank", "mars", "ari", "tokc", "emd", "xlc", "pak", "wild", "scrt", "btcred", "earth", "dtrc", "guess", "golf", "chess", "delta", "tkr", "xov", "atom", "gb", "kurt", "phs", "mnc", "prtx", "deus", "tgc", "cct", "boli", "drxne", "cj", "post", "lcp", "jew", "ltb", "tit", "j", "havy", "usc", "bbk", "ccn", "eltcoin", "aced", "fntb", "btr", "mojo", "space", "dgs", "jin", "wgo", "xbl", "xcxt", "icn", "pasl", "arco", "frc", "spk", "xct", "shdw", "grlc", "tds", "cno", "cjt", "actp", "mcap", "tok", "euno", "hc", "dsr", "cnt", "azart", "zzc", "xre", "crc", "bigup", "stn", "arion", "c2", "nox", "xbtc21", "qtl", "iq", "daxx", "neva", "gmcn", "ddf", "stv", "swing", "300", "rpc", "js", "din", "hth", "flm", "src", "xstc", "hvco", "pkb", "duo", "pgn", "bsty", "ethd", "infx", "cat", "zba", "bost", "glt", "ent", "888", "dbtc", "8bit", "611", "sigt", "mscn", "xco", "ery", "qbc", "mst", "bumba", "fans", "uet", "xmct", "lea", "bern", "vprc", "drm", "mftu", "chan", "xrh", "acoin", "boat", "plan", "zur", "more", "grn", "dtc", "imx", "nto", "dlc", "ragna", "soon", "jiyo", "dalc", "$$$", "red", "zmc", "taj", "cach", "grph", "fuzz", "gcc", "ims", "arepa", "bitf", "gp", "soil", "exn", "drs", "tch", "b@", "dach", "nuko", "euc", "pxi", "brat", "nyex", "plc", "ammo", "all", "vta", "hbc", "socc", "qbic", "ltcr", "ams", "cf", "ytn", "vec2", "cab", "trdt", "plura", "nro", "pos", "mcrn", "bln", "cmt", "goss", "pex", "pie", "pnx", "zyd", "cnnc", "visio", "flax", "gpl", "coal", "imp", "bnx", "scs", "eco", "plnc", "knc", "jobs", "icob", "cpn", "btcone", "mar", "benji", "grim", "adcn", "icon", "honey", "may", "str", "ntwk", "btpl", "vlt", "btq", "roofs", "milo", "esc", "urals", "song", "bip", "cxt", "luna", "geert", "stars", "placo", "lbtc", "krone", "sfc", "ltcu", "volt", "prc", "arb", "ibank", "slevin", "crdnc", "els", "atx", "gls", "wbb", "worm", "pcoin", "dollar", "rkc", "vuc", "argus", "ponzi", "creva", "bas", "ctic2", "eagle", "itz", "bsc", "gsr", "conx", "mgm", "coupe", "women", "acp", "adn", "ctic3", "sandg", "nanox", "vltc", "ai", "lvps", "hmc", "at", "ablx", "acc", "aces", "dnz", "aeg", "adk", "aky", "sds", "alc", "abc", "altx", "amo", "avh", "ani", "anon", "antx", "abx", "atc", "arlize", "atcc", "abdt", "av", "at", "axiom", "baas", "bnk", "bsn", "bkbt", "bet", "bether", "bff", "boc", "birds", "btbc", "bcv", "btad", "bifi", "god", "bcx", "xpat", "bitok", "bte", "bsr", "but", "blazr", "bcdn", "bqt", "pass", "boe", "bt2", "btcm", "bub", "bubo", "bu", "candy", "carat", "car", "c8", "bcard", "cit", "iov", "cedex", "cel", "cen", "cheap", "chex", "civ", "ckusd", "cld", "club", "cmit", "cfc", "c2p", "cet", "meet", "cen", "comp", "cms", "cms", "ccc", "coni", "csm", "can", "cnet", "cor", "cotn", "cou", "cplo", "crop", "crd", "crypt", "che", "cif", "cefs", "ctrt", "qbt", "cre", "cyder", "dacc", "dart", "dasc", "dac", "dfs", "dft", "daxt", "dpn", "don", "drg", "dutch", "dws", "dmc", "eag", "ecoreal", "edu", "ejoy", "epc", "eli", "elli", "emb", "empr", "ett", "eds", "egcc", "ent", "black", "eplus", "era", "erc20", "esco", "est", "ess", "etz", "edt", "ech", "elite", "esn", "exc", "xuc", "ext", "fair", "fap", "frgc", "ft", "frrn", "fil", "bit", "bitcf", "foin", "fmf", "frn", "fundz", "fto", "ges", "gcs", "gze", "gene", "xgs", "gtm", "gve", "grx", "gmx", "gbg", "gdc", "gio", "gse", "hallo", "hrc", "hsc", "gard", "hdac", "hsn", "hero", "high", "hight", "hit", "hdlb", "hold", "hnc", "hyb", "hyc", "hyper", "hpy", "ibtc", "idol", "indi", "ifp", "ifc", "xin", "inc", "ino", "inb", "insur", "iic", "icr", "incx", "xot", "idt", "ihf", "ipc", "iqn", "iqt", "swtc", "joint", "kbc", "karma", "kcash", "key", "kxc", "kdc", "know", "kwh", "labh", "latino", "lemo", "lst", "lthn", "luc", "levo", "light", "lbtc", "lina", "lft", "lxt", "lrn", "lstr", "mag", "magn", "mlc", "marx", "mct", "mxm", "meetone", "mero", "mex", "mib", "minex", "mir", "mri", "mrq", "mnp", "molk", "mof", "xmc", "xmo", "mcc", "msd", "mt", "nam", "namo", "neog", "ner", "newos", "ncp", "nug", "obtc", "oc", "of", "olmp", "omc", "ong", "open", "obt", "rdc", "ors", "otb", "pcs", "got", "paxex", "pax", "pyn", "pdx", "pco", "pnt", "phon", "pts", "pxc", "plc", "ply", "plx", "psm", "gary", "pres", "prs", "pai", "pc", "prn", "proud", "xpx", "npxsxem", "pgt", "pwr", "qntu", "qube", "xqn", "quro", "rbbt", "rcn", "read", "rcd", "rtl", "rpm", "richx", "rox", "rpl", "xry", "rrc", "rbmc", "rblx", "runners", "sins", "sfu", "skr", "sal", "sno", "seal", "sc2", "seer", "b2x", "sha", "sak", "she", "show", "scc", "sigma", "six", "sda", "sjw", "sac", "snip", "slt", "sono", "sop", "spnd", "xid", "stc", "kst", "stex", "scc", "sjcx", "sbtc", "sgcc", "ect", "sup", "tle", "tcn", "tell", "ter", "tesla", "tmtg", "get", "tos", "tv", "topc", "tdc", "trio", "trxc", "turbo", "tkt", "twist", "ubc", "ubex", "uct", "ust", "ubtc", "unrc", "uip", "use", "vlc", "vct", "vdg", "vstr", "vtho", "vivid", "acdc", "vsc", "w3c", "wa", "web", "weth", "wt", "wic", "wiki", "wc", "wink", "win", "pass", "wit", "wbl", "wwb", "wxc", "wys", "xcel", "xrt", "xtrd", "ylc", "you", "uc", "ycc", "yuki", "zb", "zp", "zengold", "zse" };
            string[] moedas = { "qntu" , "nxs", "xdn", "zap","aeon" , "maid", "swt"};
            foreach (var moeda in moedas)
            {

                
                //coinegg so recebe BTC
                //var x = GetCoinEgg.get(moeda);
                //if (x != null && x.asks != null && x.bids != null) market.Add(new Market { ask = x.asks[0][0], bid = x.bids[0][0], Coin = moeda, Exchange = "CoinEgg" });
                

                //yobit muitas carteiras desabilitadas
                //var x = GetYobit.get(moeda);
                //if (x != null && x.asks != null && x.bids != null) market.Add(new Market { ask = x.asks[0][0], bid = x.bids[0][0], Coin = moeda, Exchange = "Yobit" });
                //bittrex
                var x2 = GetBittrex.get(moeda);
                if (x2.success == true)
                {
                    market.Add(new Market { ask = x2.result[0].ask, bid = x2.result[0].bid, Coin = moeda, Exchange = "Bittrex" });
                }
                //cryptopia
                var x3 = GetCryptopia.get(moeda);
                if (x3 != null && x3.Data != null && x3.Success == true) market.Add(new Market { ask = x3.Data.AskPrice, bid = x3.Data.BidPrice, Coin = moeda, Exchange = "Cryptopia" });
                //binance
                var x4 = GetBinance.get(moeda);
                if (x4 != null && x4.asks != null && x4.asks != null && x4.asks.Count() > 0) market.Add(new Market { ask = x4.asks[0][0], bid = x4.bids[0][0], Coin = moeda, Exchange = "Binance" });
                //hitbtc
                var x5 = GetHitBtc.get(moeda);
                if (x5 != null && x5.ask != null && x5.bid != null && x5.ask.Count > 0 && x5.bid.Count > 0) market.Add(new Market { ask = x5.ask[0].price, bid = x5.bid.Count > 0 ? x5.bid[0].price : 0, Coin = moeda, Exchange = "HitBtc" });
                
                var comprar = market.OrderBy(m => m.ask).Where(m => m.Coin == moeda).FirstOrDefault();
                var vender = market.OrderByDescending(m => m.ask).Where(m => m.Coin == moeda).FirstOrDefault();

                if (comprar != null && vender != null)
                {
                    lucro = vender.bid - comprar.ask;
                    porcentagem = comprar.ask > 0 ? Math.Round(((vender.bid - comprar.ask) * 100) / comprar.ask, 2) : 0;
                    if (lucro > 0 && porcentagem <= 15) {
                        File.AppendAllText(@"c:\arbitragem.txt", String.Format("{3} | {4} | {0} | {1} | {5} | {6}%" + Environment.NewLine, comprar.ask, vender.bid, vender.bid - comprar.ask, moeda, comprar.Exchange, vender.Exchange, porcentagem));
                        Console.WriteLine("Compra {3} na {4} por {0} vender por {1} na {5}, diferenca {2} {6}%", comprar.ask, vender.bid, vender.bid - comprar.ask, moeda, comprar.Exchange, vender.Exchange, porcentagem);
                    }
                }
                }
                Console.ReadLine();
        }
    }
}
