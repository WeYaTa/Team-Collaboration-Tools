Judul : Aplikasi Pencatat Pengeluaran

Nama Anggota : 

	- Wesley Yando Tantra (03082170008)
	
	- Martin Tricia Tanzil (03082170001)
	
	- Vincent (03082170002)

Isi Tugas : (user stories)

Input : 

	- Tanggal pengeluaran
	
	- Aktivitas pengeluaran (membeli, menyewa, cicilan, dsb)
	
	- Pengeluaran per aktivitas
	
	- Gaji per bulan
	
	- List benda/jasa yang tidak menjadi prioritas
	
Proses :

	1. user dapat menginput tanggal pengeluaran.
		1.1 Jika tidak ada tanggal yang diinput, akan dianggap tanggal hari ini.
		
	2. user dapat menginput/mengetik aktivitas pengeluaran (barang/jasa).
		2.1 user dapat memilih aktivitas tersebut termasuk dalam kategori barang atau jasa.
		2.2 user akan diperingatkan jika user belum menginput apa-apa hari ini.
	
	3. user dapat menginput harga/pengeluaran setiap aktivitas.
		3.1 Jika ada yang kosong akan diberi peringatan untuk mengisi harga.
	
	4. user dapat menginput gaji per bulan (opsional) dan tanggal pengambilan gaji.
		4.1 Jika pengeluaran bulan ini sudah mendekati jumlah gaji per bulan akan diperingatkan (warning).
		4.2 Jika sudah mendekati tanggal pengambilan gaji, akan diperlihatkan sisa keuangan user.
		4.3 Jika gaji tidak diinput, tidak akan ada warning atau perhitungan lainnya
		
	5. user dapat melihat total pengeluaran dalam jangka waktu yang dipilih user
		5.1 Jika user tidak memilih jangka waktu, maka akan ditampilkan pengeluaran bulan ini.
		5.2 user dapat melihat list barang dan jasa yang dibeli/disewa sesuai dengan jangka waktu yang dipilih user.
		
	6. user dapat melihat total pengeluaran sesuai dengan kategori (barang/jasa) yang dipilih user.
		6.1 user dapat melihat list barang atau jasa yang dibeli/disewa (sesuai kategori).
		
	7. user dapat menginput barang atau jasa apa saja yang tidak menjadi prioritas (tidak penting bagi user).
		7.1 user akan diperingatkan jika user menginput barang/jasa yang tidak menjadi prioritas.
	
	8. user dapat menentukan batas pengeluaran per bulan.
		8.1 user akan diperingatkan jika pengeluaran sudah mendekati/mencapai batas pengeluaran.
	
	9. user dapat memilih pengeluaran per bulan dihitung setiap tanggal berapa.
		9.1 jika user tidak memilih tanggal namun tanggal pengambilan gaji ada, maka akan dihitung dari tanggal pengambilan gaji.
		9.2 jika user tidak memilih tanggal dan tidak ada tanggal pengambilan gaji, maka akan dihitung dari tanggal 1.
		
	10. user dapat melihat rata-rata pengeluaran per bulan atau per hari sesuai dengan pilihan user.
		10.1 rata-rata ini dapat digunakan sebagai patokan untuk pengeluaran bulan depan.

Output :

	- List rincian tanggal, aktivitas, dan harga pengeluaran dalam bentuk tabel.
	
	- List total pengeluaran sesuai kategori yang dipilih (semua, barang saja, jasa saja, dsb)
	
	- Peringatan sistem sewaktu-waktu jika pengeluaran sudah melewati gaji/batas pengeluaran yang telah ditetapkan.