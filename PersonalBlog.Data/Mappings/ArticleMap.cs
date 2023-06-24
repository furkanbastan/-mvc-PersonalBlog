using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entity.Entities;

namespace PersonalBlog.Data.Mappings;

public class ArticleMap : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        string article = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque, iure natus voluptates, corrupti repudiandae inventore perspiciatis autem quos necessitatibus consectetur delectus. Perspiciatis voluptate omnis odit vero quod vitae quisquam a.
Perspiciatis a repellendus atque, perferendis consectetur, provident nihil quos, odio quaerat eaque fugiat. Ex a voluptates officia quo mollitia perspiciatis ratione illo adipisci asperiores consequatur. Ab dicta impedit voluptas veritatis.
Libero nihil rem quos ab tempore veniam, facilis ut et odit voluptatem, illo dolores eligendi veritatis praesentium aut enim magnam numquam. Error tempora sit fugit repudiandae ex dolores ipsum aperiam.
Blanditiis atque velit sed eum modi, officia nisi error quo, ipsa, quam commodi. Quasi minus nesciunt earum quos quam alias quo optio esse accusantium, quia, possimus et placeat incidunt fuga?
Distinctio esse rem excepturi, officiis, amet placeat ipsa eos adipisci itaque labore ipsam tempora sapiente corporis odit quas a consectetur veritatis earum ratione? Doloribus enim ipsa labore, tempore beatae eveniet!
Cumque rem, laudantium, debitis ea animi veritatis nostrum eaque eum hic a temporibus illum voluptatum quod, possimus praesentium maiores deserunt doloremque minima provident aliquid? Aliquid ipsum eaque voluptatum repellat magni?
Fugit ipsam commodi sequi odit. Ut libero nemo quisquam magnam tempore, aliquid dolorem quia minima vero quaerat consequuntur eos repudiandae eveniet ipsum cumque rem eum dicta repellendus voluptatem delectus inventore.
Nam saepe suscipit quas corrupti, rem dolore esse amet animi laborum nobis culpa quis deserunt sed quos nulla delectus reprehenderit quisquam voluptates, tenetur illum similique ratione nesciunt porro natus! Enim.
Ducimus harum nihil assumenda. Reprehenderit dicta ipsa, quia explicabo eius perferendis, illum, quae illo quasi similique tempora! Obcaecati, reiciendis eaque. Praesentium veniam magni tempore perferendis eum laudantium autem minima quidem!
Illo quod doloribus enim veritatis dignissimos nesciunt perferendis. Saepe soluta deleniti maiores vero illum ipsum. Natus ipsam perferendis, dignissimos dolor et esse perspiciatis, eveniet, dicta fugiat non harum obcaecati voluptates?
Aut, quibusdam molestias. Impedit ipsa veniam fuga itaque non dolores unde nisi architecto distinctio nihil labore rem beatae illo, amet minima? Dolore, eius quae expedita iure sint minus aspernatur possimus!
Soluta ipsum laborum dolor. Cum perspiciatis, expedita eaque ipsam, quam inventore quis enim laudantium hic ipsa sed deleniti corrupti culpa. Quia, qui vitae sapiente totam libero odit perferendis quidem odio?
Natus esse numquam distinctio ad praesentium provident optio minus earum ratione corrupti? Aut quisquam exercitationem officiis consequuntur fugiat possimus, odit minima. Quos fugit quasi eum officiis distinctio similique dolorum suscipit!
Consequatur cupiditate, eaque velit nesciunt a excepturi eum, debitis repellendus accusantium tempora quaerat. Consequuntur laborum nemo sapiente deleniti nostrum pariatur ab quos officia voluptatibus distinctio officiis temporibus, veritatis eligendi placeat?
Rerum, unde. Officiis atque porro dolore dolorum fugiat vel ratione! Incidunt obcaecati veniam distinctio quo facilis praesentium at iure vel rerum expedita aliquam deserunt eius pariatur perspiciatis, quos dicta dolor!
Velit, aliquid. Iusto aut est itaque magnam id rerum. Amet nobis, quae accusamus autem esse expedita provident ducimus quisquam earum ratione quos iste dolor non nemo facere voluptatum cupiditate quidem.
Exercitationem architecto quisquam odio a quos nemo magni, harum suscipit dolore debitis? Ratione rem repellat dolore explicabo libero dolorem corrupti quisquam ex repudiandae aperiam error voluptatibus, accusamus quo, quam architecto.
Expedita assumenda odit sunt incidunt saepe neque aliquid consequuntur exercitationem iure id reiciendis, aperiam, dignissimos architecto vitae porro dolore animi doloremque eos at! Doloremque architecto molestias corrupti ipsam doloribus consequatur?
Ab voluptates dignissimos quibusdam voluptate impedit. Expedita at dolorem rerum sint qui voluptates laboriosam, quod iusto quae saepe doloribus dolor voluptate nihil debitis aspernatur velit aliquid soluta dolores porro ipsa!
Quidem repudiandae fugit necessitatibus velit, nobis tempore dolor quae unde error vitae eligendi asperiores exercitationem quo doloribus fugiat earum. Illum a id ab, tempora mollitia eum nesciunt ipsa ut impedit.
Incidunt recusandae adipisci eligendi impedit magni enim dignissimos itaque. Magnam reiciendis, nam quidem tenetur perferendis odio! Odio voluptatem id placeat, autem expedita iure fuga quam soluta, sed, dicta eaque. Aliquam.
Reprehenderit velit quia recusandae vero qui consectetur nihil obcaecati tenetur sapiente eos est soluta neque deleniti ut eaque, asperiores, iusto labore harum dolor suscipit numquam! Unde facere dolorum commodi dolore.
Ab est reprehenderit, ducimus neque hic pariatur quasi recusandae, laborum facere voluptatibus odit eum! Odit assumenda dolores at delectus est vel laboriosam, nostrum reprehenderit aut blanditiis? Nisi eveniet expedita sint.
Minima doloremque illum rerum possimus recusandae dolorem, at, atque molestiae ipsum, blanditiis veritatis quaerat ab inventore quod perferendis? Provident quidem, dolorum maiores voluptate vero et ab officia a culpa. Voluptatem?
Obcaecati doloribus voluptates fugit illo harum, veritatis itaque. Ex ipsum veniam enim nesciunt quo cupiditate alias blanditiis fugiat, in doloribus quas fuga cum eaque asperiores dolorem, laudantium quisquam. Ipsam, minima!
Minus dolore nesciunt, neque tenetur explicabo eveniet totam pariatur consequuntur eaque, ipsum, dolorum excepturi alias aut quam. Voluptate, dignissimos esse commodi eos dolorem nulla quas libero ipsum soluta quos ut?
Dicta ipsa quod sint dolorem eaque quas modi sed illo id autem adipisci vel corrupti labore nam ab eum qui vitae, illum cumque itaque recusandae perferendis suscipit? Sunt, fugiat saepe!
Sit aperiam incidunt totam sequi quam, eveniet provident doloremque dolorem voluptate corrupti modi velit assumenda neque explicabo vel ipsa id nam similique, nihil itaque repudiandae rem et? Possimus, totam tempore.
Sunt modi nesciunt tenetur minima illo! Aut quod inventore vitae id perferendis dolores autem distinctio, non recusandae nisi velit veniam. Voluptatem ipsum ullam laborum quos, tempora voluptate asperiores odit vel?
Quasi magnam mollitia voluptas, qui provident et iusto distinctio optio debitis quibusdam eligendi eaque fuga porro minima reiciendis natus esse eos maiores vero aliquid perspiciatis quisquam officiis! Repudiandae, a perferendis!
Vero voluptatum itaque corrupti culpa repudiandae ad quisquam cum fugiat necessitatibus at quidem, nihil esse doloremque molestias eius et atque quia, magnam neque mollitia! Nesciunt possimus fugit mollitia id aspernatur!
Inventore eligendi laborum repellat assumenda sapiente suscipit odio nesciunt quo amet officiis? Fugit ducimus vero quibusdam corporis quasi, consectetur debitis commodi placeat quisquam! Ipsum, quas aliquid dolorem temporibus at possimus.
Natus eum iure nesciunt distinctio! Animi, eveniet! Cum, pariatur. Doloribus fuga vitae laborum. Nostrum corporis aliquid aspernatur esse rerum quam eligendi fuga totam modi, distinctio iste odio, quis veritatis quisquam!
Nostrum eligendi pariatur, maiores quidem eaque commodi saepe est cum quia dolorum harum repudiandae voluptatibus! Incidunt, harum praesentium tempore voluptatum eligendi asperiores tenetur dolores nulla quo adipisci eum labore quas.
Consectetur quibusdam eos, reiciendis dolores voluptas labore laboriosam ex doloribus praesentium, velit doloremque ab rerum quae veniam, obcaecati facere error unde aperiam officia magni. Voluptate vero laboriosam autem perspiciatis quas?
Repellat numquam repellendus vitae laborum quaerat cum, sunt fuga, exercitationem vel accusamus ipsam in unde. Nesciunt animi eius similique dolorum nihil. Voluptatum dolores incidunt ratione sint perspiciatis esse mollitia quia!
Ex beatae quos doloribus ipsum eum exercitationem itaque, consequuntur ullam eos sed. Itaque animi debitis consectetur ex adipisci vel quidem assumenda sequi quae! Esse tempore, harum mollitia id quis temporibus!
Ullam iste quo recusandae cupiditate accusantium assumenda quae, ab consequuntur saepe sequi voluptate ad, a neque necessitatibus est excepturi laudantium dicta libero voluptatibus. Dicta quas consectetur ipsa nemo repellat quo.
Cumque, dolorum placeat odit minima harum consequuntur voluptas quo qui! Est ratione modi fugit eaque veritatis, officia sunt temporibus quasi, optio, repellendus assumenda. Ea, excepturi consequatur! Ut praesentium autem dolorum.
Esse ducimus recusandae sint debitis eaque laboriosam minus nesciunt quisquam. Expedita magni facere temporibus veniam, laboriosam esse dignissimos minus velit id placeat earum sed dolor sapiente modi qui aperiam odit?
Animi saepe voluptatem ullam esse, sint amet repellat quibusdam, ducimus optio, voluptates pariatur inventore expedita aspernatur. Minus quaerat velit necessitatibus. Sit quae error deleniti eius praesentium eos exercitationem omnis est.
Sequi atque ipsum eligendi. Minus, itaque. Sint odit ducimus delectus, voluptas officia autem aperiam perferendis tempore fuga consequatur molestiae maiores excepturi eaque sed tempora nisi blanditiis dolores molestias saepe. In.
Cupiditate, dolor quam? Magni suscipit veritatis fugiat enim inventore libero, cupiditate ex consequatur laboriosam tenetur vero, numquam at iure a voluptates assumenda. Perspiciatis iusto, accusamus quos enim fugit odio eos.
Nisi vero minus eius autem assumenda impedit reiciendis blanditiis placeat corporis sit omnis voluptatem molestias atque, maiores ea aliquid totam cupiditate odio mollitia, perferendis, adipisci ipsa? Suscipit quaerat vitae laudantium!
Deleniti, porro beatae itaque possimus magnam dolor fugiat modi similique tempore perspiciatis quae consequuntur, rem asperiores quos quis, facere doloremque nemo optio facilis consectetur dolorem? Incidunt eum dolor quasi at!
Ducimus odit possimus aliquid, sint voluptate impedit laborum velit iure maxime, quae culpa fugit nihil aperiam dolorem. Rerum impedit eveniet provident quia, earum perferendis natus voluptatum quidem fugiat placeat assumenda!
Cum accusamus omnis vitae nam, illo aliquid enim dolores mollitia dolorem voluptatibus adipisci dolorum eveniet fuga soluta, nostrum odit. Id, dolores dicta cupiditate dolorum itaque molestias optio eveniet totam laudantium!
Aut voluptatem nulla officiis possimus sit aperiam esse suscipit quis! Accusamus rerum, eveniet iure a cumque blanditiis fugiat neque, hic commodi nam sed ad nihil incidunt esse. Facere, debitis dignissimos!
Quidem ipsa itaque, quod tempora quae accusamus modi et? Sapiente aliquid velit facilis vero optio minima quis, inventore sed aut porro voluptatum veniam officiis illum enim possimus? Repudiandae, qui tenetur!
Nulla porro, molestias quos eius mollitia aliquam optio numquam fugiat velit nisi, nemo provident suscipit rem perferendis a dolor, quas aliquid obcaecati nam totam delectus necessitatibus? Saepe dolore atque maxime.
Vel dolore sint quam quisquam quidem! Inventore fugit, consectetur error vitae facilis animi. At rerum odio ullam, ipsum odit impedit tempora, maxime debitis sapiente doloribus, rem ipsam asperiores nulla. Voluptatum.
Dolore dolores, corrupti impedit facere dolorem optio aut officiis provident atque molestiae nesciunt, quasi fugiat aliquam enim quos corporis minus nisi sint consectetur perferendis magni cumque! Sapiente molestiae reiciendis autem.
Rerum, odio deleniti saepe a recusandae illo laborum minima aliquid rem aliquam, non voluptas iste blanditiis similique autem fugiat laboriosam repellat sequi facilis. Mollitia, nostrum neque autem veritatis vel facilis.
Adipisci eaque sequi vel et amet. Nostrum quam amet blanditiis culpa voluptates impedit porro, quas quae fugit reiciendis ad maiores aspernatur dolores dolorum sunt natus autem ipsum. Corrupti, labore consequatur.
Cum doloremque perspiciatis, vero quo reprehenderit accusamus deserunt pariatur qui sit omnis impedit suscipit voluptatibus ipsa, excepturi modi! Cum unde placeat qui officiis dolor accusamus odit tempora sapiente, tenetur quae.
Repellat ducimus omnis consequuntur deserunt nulla sunt placeat aliquid voluptatum? Omnis doloremque quidem, rem sit placeat recusandae deserunt similique, culpa maxime sequi labore vero. Dolore incidunt neque commodi voluptas hic.
Iusto, a unde quis est corrupti harum suscipit dignissimos laudantium consequatur ab hic aut quas magni minus modi atque neque itaque, voluptatum at. Eaque animi ullam architecto nihil laborum vitae?
Facere quidem nesciunt velit architecto culpa. Delectus voluptate deserunt explicabo neque ipsum consectetur corporis quaerat, at id nihil provident vel quisquam sapiente labore ipsam nobis. Aspernatur dignissimos sunt velit dolores?
Recusandae doloribus cum cupiditate voluptate ducimus exercitationem laborum corrupti nemo debitis sequi rerum, error possimus suscipit obcaecati tenetur commodi dignissimos aperiam quis fugiat accusantium veniam facilis. Perspiciatis, soluta amet? Ipsum.
Reiciendis nihil, est accusantium enim doloribus, vel quam beatae explicabo officia ad earum! Esse perferendis numquam aut quasi repellat tenetur temporibus nihil eius non, eveniet vero aliquid voluptas doloribus molestiae!
Distinctio rerum vel, cumque illum ipsa, reprehenderit fugit ex minus libero magni accusamus at neque, laudantium tempore a saepe non ad placeat corporis dolor necessitatibus. Autem, adipisci? Ipsum, blanditiis eveniet.
Maiores totam unde obcaecati magni, aspernatur voluptates nihil reiciendis sapiente rem possimus soluta numquam dolores. Qui quis voluptatem eaque dolorum, rem quidem eius sunt autem beatae ex quo natus et?
Soluta repellat cupiditate officia culpa qui at ab minima quos modi quibusdam vitae hic maxime maiores laboriosam nam velit, beatae officiis aliquid nobis quam cumque illum! Quidem dolor soluta ipsa!
Earum dignissimos voluptates consequuntur nobis dolore ipsum natus cupiditate tempore repellendus aspernatur, quaerat officiis ratione velit magnam perferendis illum, nesciunt libero sed. Deleniti quos animi, tenetur tempora atque voluptate repellendus.
Ut culpa harum nobis necessitatibus quisquam exercitationem ratione modi neque possimus ipsa iure, sed, excepturi consequuntur laboriosam deleniti, esse repellat dolorum atque at nostrum similique maiores debitis sunt fugiat. Enim.
Quia omnis repellendus molestias quidem suscipit quis natus voluptatum sint, cum voluptatem commodi ullam porro esse, impedit ducimus architecto consequatur minus necessitatibus accusantium quo nam asperiores! Rerum, excepturi. Iure, voluptatibus?
Assumenda aperiam tenetur est, qui beatae labore corporis saepe obcaecati tempore iste voluptatibus possimus placeat dolores porro explicabo, ratione voluptas, fuga dolor adipisci rem. Reiciendis maxime magnam qui earum inventore.
Minima incidunt rerum molestiae omnis in odit eaque sunt! Nemo illo eaque dicta quisquam, delectus molestiae praesentium officia, asperiores velit, autem veniam. Amet adipisci totam similique! Sapiente optio reiciendis hic!
Incidunt porro corporis doloremque natus laboriosam obcaecati sapiente non pariatur, inventore adipisci! Quae, consequatur accusantium expedita adipisci earum natus nostrum doloremque ipsum odit eligendi sequi vitae omnis quia beatae eos!
Facilis veritatis, pariatur quia molestiae libero dolore similique nostrum recusandae fuga. Tempora consectetur voluptas placeat deleniti at velit dignissimos cupiditate aspernatur fugiat nesciunt. Iure hic aliquam dolorem quasi quod error.
Facere asperiores fugit perferendis error aspernatur consectetur magnam. Aliquam provident eaque odio laborum praesentium perspiciatis, distinctio laudantium in animi, placeat vitae. Id culpa fugiat dolore dicta, quis molestias totam aliquid!
Suscipit voluptas iste ab, sit dicta eveniet perferendis, odio molestias libero nisi soluta dolore doloribus ex velit aliquam quas! Natus amet blanditiis voluptatum veritatis praesentium eos, consectetur vero officiis ratione!
Natus vero similique sed ullam omnis autem, quam, animi voluptatum aspernatur provident perspiciatis, dolorem distinctio qui nihil eaque ab. Tempora incidunt quae minus? Error ut et nam porro. Cupiditate, dolores!
Reprehenderit voluptatum beatae sed nihil laudantium, eos officiis modi veritatis id autem mollitia perferendis a, repellat sit vel consequatur ipsam omnis in praesentium molestias accusamus repudiandae tempora. Hic, sequi beatae?
Dolorem voluptatem maiores quibusdam laboriosam qui modi voluptatibus officia ipsa! Sequi perferendis minima quod, hic temporibus cumque laborum tempora exercitationem recusandae eos, dignissimos laboriosam, quo non itaque eius earum dolor.
Assumenda neque quia dolore sed similique odit pariatur nulla, aliquam libero, id facilis quas ut doloribus deserunt nihil molestiae asperiores suscipit dicta at ratione. Deserunt magni consequuntur aperiam. Sapiente, dolore?
Veniam officia nisi eos ducimus porro sint impedit perspiciatis totam in nihil mollitia corrupti quas eius tempore placeat, labore dolor molestias, corporis praesentium id. Nihil cupiditate nulla modi officiis eligendi?
Ducimus commodi temporibus eveniet repellendus obcaecati cum ipsum fugiat qui consequuntur quod magnam nihil velit veniam, sunt esse quibusdam vel, accusantium eius aspernatur est non nobis quaerat omnis. Corporis, magnam?
Totam in quibusdam mollitia quaerat non vel sapiente, molestias dolor recusandae ullam a odio dolores possimus magni qui maxime dicta doloremque repudiandae beatae illum? Ducimus dolores dicta error possimus perferendis?
Dolor et eaque aliquid maiores beatae labore soluta odio vitae voluptates, harum accusamus quos omnis id, error laudantium doloremque unde sunt quisquam! Quasi aliquam, autem molestiae dolorum impedit eaque sapiente.
Pariatur, a? Ipsam ad cum enim doloremque corrupti consequatur minus consectetur accusantium quo nulla hic dolor possimus id est eos magnam, quis quaerat necessitatibus. Similique alias dolor quae eaque iste!
Eos eveniet dolorem in repellendus vel. Harum tenetur quis nihil omnis cupiditate nam quasi fugiat. Nostrum quibusdam inventore tempora quae vel dignissimos eius, perspiciatis officia ducimus, itaque, vitae fugiat unde!
Aliquam suscipit officiis error ipsum necessitatibus vitae labore in, reiciendis, ab eaque odio, deserunt autem velit quis dicta voluptates esse aliquid praesentium. Itaque totam consequatur aspernatur, recusandae qui expedita dolores!
Eius repellendus ipsa fugiat commodi corporis dignissimos maxime quaerat, hic quia, dolor vitae exercitationem accusamus, nemo dolore sunt sit iste dolorum! Quod assumenda incidunt, quas doloribus rerum at. Vero, natus.
Nisi quos, error beatae esse nobis repudiandae minus molestias voluptatibus aspernatur! Iste eius illum optio corporis porro. Molestiae aspernatur distinctio, illum ipsam possimus et unde maiores magni sint quos consectetur.
Tenetur porro, pariatur ipsa, deserunt quibusdam unde sint nostrum perspiciatis ut amet qui a aspernatur veniam, necessitatibus iusto. Tempore obcaecati eius quia, atque soluta minima quidem aperiam hic maxime tempora!
Nam ad odit voluptate, non nemo recusandae expedita perspiciatis autem rerum iure odio quaerat nihil ex nesciunt. Animi quidem numquam veritatis nam, in possimus mollitia vero fugit error nulla quod?
Laborum quos nemo natus tempore optio blanditiis unde cumque repellat corporis debitis repellendus accusamus neque voluptatibus ab recusandae explicabo aliquid, accusantium aut minus consequatur aliquam cupiditate dolore aperiam enim! Totam!
Perferendis, totam. In repellat distinctio, dolor sint iusto neque, natus ratione, expedita odio quo possimus aspernatur. Earum non modi adipisci pariatur hic ipsam impedit qui molestias dignissimos. Exercitationem, perspiciatis labore.
Ipsa corporis veritatis in, quos voluptatem possimus maiores incidunt nesciunt earum! Dignissimos quasi nostrum, alias placeat ab, perferendis fuga nobis sit eligendi laborum, inventore quibusdam maiores explicabo cum dicta magnam?
Blanditiis ad est excepturi quo nesciunt sit in! Perferendis alias est ut hic magnam aspernatur officia cumque, impedit facilis? Harum esse ipsum enim? Obcaecati quisquam placeat, laudantium minima possimus aliquid?
Laudantium, soluta dolores sapiente molestias sunt at optio dignissimos tenetur esse, expedita, eveniet corrupti. Esse hic in atque! Laudantium placeat sapiente ea eaque possimus similique, consequuntur nam optio facere necessitatibus?
Corporis expedita repellat consectetur hic earum deleniti iusto? Delectus tempora ex cumque iusto illo fuga eos laudantium ea doloribus ratione molestias labore, minus sed ut ipsum nihil cupiditate, exercitationem eius.
Nemo ducimus veniam quod rerum numquam doloremque consequuntur hic molestiae provident, est iusto error explicabo cumque eius cum unde asperiores impedit voluptatem! Accusantium error ullam porro quidem molestias aut veniam.
Beatae praesentium doloremque suscipit. Aperiam ducimus labore adipisci voluptate assumenda ab aliquid culpa ex molestias odio deleniti, impedit, provident obcaecati eius tempora dolorum fugiat sunt dicta illum. Maxime, est aspernatur.
Reiciendis assumenda, magnam et a autem quo hic corporis rem? Sit obcaecati, deserunt facere dicta nulla porro, modi laborum accusamus, expedita placeat molestiae id. Nihil non aliquam nulla ullam excepturi.
Quos commodi aut sapiente incidunt corporis nisi maxime doloribus rem nulla animi nostrum pariatur voluptas est voluptate, ipsam aperiam. Autem nulla eius dolorum? Asperiores ipsa ipsam quia minus veritatis incidunt!
Mollitia saepe accusantium debitis sunt magnam aliquid fugiat itaque id error facilis iure doloremque laudantium, repellendus rerum eius aut ipsam cupiditate maxime ea quas odit. Vel aliquam ea aperiam cupiditate!
Totam expedita temporibus, illo nemo necessitatibus deleniti dolor, maiores, pariatur a nobis nostrum itaque explicabo officiis eligendi? Hic possimus officia placeat. Delectus unde, in dolorum provident distinctio nam dolor dolorem.
Nostrum voluptate magnam exercitationem nobis, delectus tempora ipsa! Blanditiis officiis ad eius temporibus dignissimos neque itaque fugiat quae sit, commodi autem voluptates veniam, omnis, distinctio repellat? Culpa in voluptate ad.";

        builder.HasData(
            new Article
            {
                Title = "Asp.Net Core'a Nasıl Merhaba Deriz?",
                Content = article,
                Id = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Title = "Asp.Net Core'a Nasıl Selam Demeyiz?",
                Content = article,
                Id = Guid.Parse("6dd7b93d-d7bf-5bce-91c3-ac17f3b1b336"),
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Title = "Css te nasıl uzmanlaşırız",
                Content = article,
                Id = Guid.Parse("7bc7b98d-d7bf-6dce-91c3-ac14f3b2b336"),
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            }
        );
    }
}
