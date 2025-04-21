README(Unfertig)
===

[![MSBuild](https://github.com/LPFan12/FEBuilderGBA-DE/actions/workflows/msbuild.yml/badge.svg)](https://github.com/LPFan12/FEBuilderGBA-DE/actions/workflows/msbuild.yml)

Diese Version von FEBuilderGBA wird speziell für die deutsche Fire Emblem-Community erweitert, aber ich hoffe darauf zu achten, dass sie auch für andere Sprachen verwendbar bleibt. Sie basiert auf der Version bei (https://github.com/laqieer/FEBuilderGBA).

Unsere Änderungen und Pläne
===
Momentane Änderungen:

-Für FE6 wurden zwei Zeichentabellen ergänzt, eine für den noch unfertigen LPFan-Deutschpatch und eine für den Emblemier-Deutschpatch(Beide beim Emblemier Discord-Server zu finden https://discord.gg/3xXQkPT). Für diese Deutschpatches muss die Text-Enkodierung in den Optionen jedes Mal neu eingestellt werden wenn die jeweilige ROM im Editor geladen wird(Eine automatische Erkennung ist auf absehbare Zeit nicht zu erwarten), Bilderhilfe kommt später an diese Stelle.

-Ein paar Klassen/Itemnamen wurden in den japanischen Spielversionen auf verwirrende Weise ersetzt. In einem Fall (beim Gorgonenei in FE8) führte dies bereits in der Vergangenheit zu einer großen Verwirrung in der englischsprachigen Community weil der ersetzte Name anders war als der tatsächliche im Spiel. Dies wurde korrigiert, damit diese Namen im Editor genauso angezeigt werden wie im Spiel auch.

-Anfängliche deutsche Übersetzung für das Programm selbst.

-Anfängliche Unterstützung hinzugefügt für:

Offizielle Spielversionen:
 * FE6C (Spiel-ID: AFECFQ); Dies ist die Chinesische Version.
 * FE7 206-Prototyp (Spiel-ID: AE7B01); Die Spiel-ID muss in der ROM manuell geändert werden, auf natürliche Weise hat es die selbe ID wie die japanische Version von FE6.
 * FE7 209-Prototyp (Spiel-ID: AE7G01); Die Spiel-ID muss in der ROM manuell geändert werden, auf natürliche Weise hat es die selbe ID wie die japanische Version von FE6.
 * FE7E (Spiel-ID: AE7X01); Dies ist die ROM mit Deutsch, die andere Europäische ROM ist noch nicht unterstüztzt.
 * FE8 531-Prototyp (Spiel-ID: BE8A01); Die Spiel-ID muss in der ROM manuell geändert werden, auf natürliche Weise hat es die selbe ID wie die japanische Version von FE7.
   
 Fanübersetzte Spielversionen:
 * FE6U (Spiel-ID: AFEU01); Dies ist der Englischpatch. Die Spiel-ID muss in der ROM manuell geändert werden, auf natürliche Weise hat es die selbe ID wie die japanische Version von FE6.
 * FE6D (Spiel-ID: AFED01); Dies ist der LPFan-Deutschpatch.
     
Der momentane Fortschritt ist allerdings noch nicht weit genug fortgeschritten damit es als "Stabil" zählen kann und ich kann momentan noch nicht empfehlen diese Roms zu bearbeiten. Wir übernehmen keine Schuld für zerstörte ROMs dieser Spielversionen!

Momentan geplante Änderungen:

-Vollständige Unterstüzung für alle offiziellen und fanübersetzten Spielversionen.

-Die deutsche Übersetzung von FEBuilder abschließen.

-Das Programm wenn möglich vollständiger und benutzerfreundlicher machen.

Die Koreanische Zeichentabelle
===

Sie stammt ursprünglich aus einer anderen inoffiziellen Version beim (https://github.com/delvier/FEBuilderGBA), welche von der Version auf der diese basiert übernommen wurde.

Die benutzte Tabelle ist **Johab**, welche anscheinend nur Hangul-Sylben unterstützt(Ich kenne mich da selbst nicht so aus). Es ist denkbar, dass in der Zukunft irgendwann andere Zeichentabellen auch unterstützt werden, aber auf absehbare Zeit ist zu empfehlen die Datei __FE\[678\].tbl__ im Ordner __./config/translate/ko_tbl__ zu ersetzen, wenn man alternative Zeichentabellen wie Wansung oder Windows-949 nutzen will.

Die koreanische Unterstützung ist unvollständig, weshalb manche Zeichen nicht richtig angezeigt werden, z.b. '@61A0' anstatt '마' (0xA061). Dies ist möglicherweise weil die oberen Bytes von 0xA0 bis 0xDF in Shift-JIS und Windows-932 für Einzelbyte-Darstellungen verwendet werden.

Wie bei den deutschen Tabellen muss man momentan die Text-Enkodierung bei jedem Öffnen der ROM im Editor in den Optionen manuell einstellen wenn man sie verwenden will.

Ursprüngliche FEBuilderGBA Informationen(Momentan unübersetzt/uneditiert)
===

FE_Builder_GBA
===
This is a ROM hacking suite for the Trilogy of Fire Emblem games for the Game Boy Advance.
The editor supports
 * FE6 (The Binding Blade)
 * FE7J/FE7U (The Blazing Blade)
 * FE8J/FE8U (The Sacred Stones)
Essentially, both Japanese and North American releases of all games (with the exception of FE6 being Japan-only) are supported.

Starting from the main screen, FEBuilder supports a wide range of functions from image displaying, importing and export of most data, map remodeling, table editing, community patch management, music insertion, and much more. 

This suite was made at first to help make my Kaitou patch easier to create!

The origin of the name is from 某LAND.  
However, the development language is C#. (We're in this together...)  

Of course, it's open source.
The license of the source code is GPL3.  
Please use it freely with no limitations.

Much of this project's functions are thanks to the data collected by various communities and people.
We would like to thank our hacking predecessors who have publicly shared any analyzed data. 

Details (There is a commentary at the bottom of the page, and the wiki provides other instructions)  
https://dw.ngmansion.xyz/doku.php?id=en:guide:febuildergba:index

Some poorly designed anti-virus software may misidentify FEBuilderGBA as a virus.
This is because FEBuilderGBA uses the WindowsDebugAPI to communicate with the emulator.
Please configure your anti-virus to exclude the FEBuilderGBA directory.
FEBuilderGBA is NOT virus. 
The source code is all available on github, so you can build it yourself if you are worried.


This software has no association with the official products.  
We do not need any donations as we are making this software non-commercial. 

If you really want to donate to someone, donate to the charitable organization supporting the freedom of speech on the Internet, **Freedom of Expression**, including the **EFF Electronic Frontier Foundation**. 

Of course, you are free to write articles about FEBuilderGBA.  
In some cases, you may earn some pocket money through affiliates. :)  
However, please do it at your own risk. :(  

If you have something you do not understand through hacking or the editor, please read "Manual" in "Help".  
If you find a bug that you can not solve by any means, please create report.7z from 'File' -> 'Menu' -> 'Create Report Issue' and consult with the community.
https://discordapp.com/invite/Yzztqqa
Do NOT send your ROM (.gba) directly.

SourceCode:
https://github.com/FEBuilderGBA/FEBuilderGBA

Installer:
https://github.com/FEBuilderGBA/FEBuilderGBA_Installer/releases/download/ver_20200130.17.1/FEBuilderGBA_Downloader.exe


FE_Builder_GBA
===
FE GBA 3部作のROMエディターです。  
FE8J FE7J FE6 FE8U FE7U に対応しています。  

Project_FE_GBA の画面を参考に、  
新規に判明した部分を追加しました。  
画像表示やインポートエクスポート、マップ改造まで幅広い機能をサポートします。  

怪盗パッチを作っているときに思った、こんな機能が欲しい!!という機能をすべて入れ込みました。  

名前の由来は、 某LANDのアレからです。  
ただし、開発言語はC# です。 (中の人達は一緒だしね・・・)  
C#でありますが、特にパフォーマンスに注意しているので、サクサク動くかと思います。  

当然、オープンソース。ソースコードのライセンスは GPL3 です。  
ご自由にご利用ください。  

これを作るのに、いろいろいなデータ、コミニティを参考にしました。  
解析したデータを公開してくれた先人にお礼を申し上げます。  


詳細 (ページ下部に解説集があるよ)  
https://dw.ngmansion.xyz/doku.php?id=guide:febuildergba:index

一部の出来の悪いアンチウイルスソフトが、FEBuilderGBAをウイルスと誤認することがあるようです。
これは、FEBuilderGBAがエミュレータと通信するためにWindowsDebugAPIを利用しているからだと思います。
もしそうなったら、アンチウイルスの設定で、FEBuilderGBAディレクトリを除外してください。
FEBuilderGBAはウイルスではありません。
ソースコードはすべてgithubで公開しているので、心配な場合は自分でビルドしてください。


このソフトウェアは、公式とは一切関係ありません。  
私達は非営利でこのソフトウェアを作っているので、寄付を必要としません。  
どうしても寄付したい方は、EFF 電子フロンティア財団を始めとする、インターネットでの言論の自由、表現の自由を支援している慈善団体にでも寄付してください。  

もちろん、あなたがFEBuilderGBAに関する記事を書くのは自由です。  
場合によっては、アフェリエイトでお小遣いを稼ぐこともできるでしょう。 :)  
ただし、あなたの責任において実施してください。 :(  

もし、hackromでわからないことがあれば、「ヘルプ」の「マニュアル」を読んでください。  
どうしても解決しないバグが発生した場合は、「メニュー」の「ファイル」->「問題報告ツール」から、report.7zを作成して、コミニティに相談してください。
https://discordapp.com/invite/Yzztqqa
(ROMは送信しないでください。)  

SourceCode:
https://github.com/FEBuilderGBA/FEBuilderGBA

Installer:
https://github.com/FEBuilderGBA/FEBuilderGBA_Installer/releases/download/ver_20200130.17.1/FEBuilderGBA_Downloader.exe


FE_Builder_GBA
===
它是FE GBA三部曲的ROM编辑器。  
它对应于 FE8J FE7J FE6 FE8U FE7U.  

参考Project_FE_GBA的屏幕，  
我添加了一个新发现的部分。  
我们支持图像显示，导入导出，地图重构等功能。  

当我制作一个kaitou补丁时，我想要这样的功能  

这个名字的起源是来自 某LAND。  
但是，开发语言是C＃。 （里面的人在一起...）  
它是C＃，但我担心性能，所以我认为它会工作很好。  

当然，开源。源代码的许可证是GPL3。  
请自由使用。  

我参考了各种数据和社区来做到这一点。  
我要感谢发布分析数据的前辈。  


详细信息（页面底部有评论）  
https://dw.ngmansion.xyz/doku.php?id=zh:guide:febuildergba:index

Some poorly designed anti-virus software may misidentify FEBuilderGBA as a virus.
This is because FEBuilderGBA uses the WindowsDebugAPI to communicate with the emulator.
Please configure your anti-virus to exclude the FEBuilderGBA directory.
FEBuilderGBA is NOT virus. 
The source code is all available on github, so you can build it yourself if you are worried.


这个软件与官方无关。  
我们不需要捐赠，因为我们正在制作该软件的非营利。  
如果你真的想捐赠，  
捐赠给支持言论自由的慈善组织，包括EFF电子前沿基金会在内的言论自由  

当然，您可以自由撰写关于FEBuilderGBA的文章。  
在某些情况下，您可以通过会员赚取零用钱。 :)  
但是，请自行承担风险。 :(  

如果你有一些你从hackrom不能理解的东西，请阅读“帮助”中的“手册”。  
如果您发现无法解决的错误，请在'菜单'的'文件' -> '问题报告工具'中创建report.7z，并咨询社区。
https://discordapp.com/invite/Yzztqqa
（请不要发送ROM。）  

SourceCode:
https://github.com/FEBuilderGBA/FEBuilderGBA

Installer:
https://github.com/FEBuilderGBA/FEBuilderGBA_Installer/releases/download/ver_20200130.17.1/FEBuilderGBA_Downloader.exe
