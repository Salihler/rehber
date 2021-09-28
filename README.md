## Rehber
Web ve mobil uygulamalarda kullanılabilecek telefon rehberi uygulaması!

## Kayıtlı tüm kişileri getirme

### Request
` GET api/contact/ `

    curl -X GET "http://localhost:5004/api/Contact" -H  "accept: */*"

### Response

    content-type: application/json; charset=utf-8  date: Tue28 Sep 2021 02:42:08 GMT  server: Kestrel  transfer-encoding: chunked 

## Yeni Kişi Oluşturma

### Request
` POST api/contact/ `

    curl -X POST "http://localhost:5004/api/Contact?Name=&Surname=&Company=" -H  "accept: */*" -d ""

### Response

    date: Tue28 Sep 2021 02:48:05 GMT  server: Kestrel 

## Kişi Bilgisi Güncelleme

### Request
` PUT api/contact/ `

    curl -X PUT "http://localhost:5004/api/Contact?Id=&Name=&Surname=&Company=" -H  "accept: */*"

### Response

    content-type: text/plain  date: Tue28 Sep 2021 02:54:27 GMT  server: Kestrel  transfer-encoding: chunked 

## Id ile Kişi Getirme

### Request
` GET api/contact/id `

    curl -X GET "http://localhost:5004/api/Contact/5" -H  "accept: */*"

### Response

    content-type: application/json; charset=utf-8  date: Tue28 Sep 2021 02:57:05 GMT  server: Kestrel  transfer-encoding: chunked 

## Kişiyi Rehberden Kaldırma

### Request
` DELETE api/contact/id `

    curl -X DELETE "http://localhost:5004/api/Contact/28" -H  "accept: */*"

### Response

    date: Tue28 Sep 2021 02:59:29 GMT  server: Kestrel  

## Kişiyi Diğer Bilgileri İle Birlikte Getirme

### Request
` GET api/contact/id/infos `

    curl -X GET "http://localhost:5004/api/Contact/11/infos" -H  "accept: */*"

### Response

    content-type: application/json; charset=utf-8  date: Tue28 Sep 2021 03:02:05 GMT  server: Kestrel  transfer-encoding: chunked  

## Birden Fazla Kişi Kaydetme

### Request
` POST api/contact/range `

    curl -X POST "http://localhost:5004/api/Contact/range" -H  "accept: */*" -H  "Content-Type: application/json" -d "[{\"name\":\"string\",\"surname\":\"string\",\"company\":\"string\"}]"

### Response

    date: Tue28 Sep 2021 03:03:24 GMT  server: Kestrel 

## Birden Fazla Kişi Silme

### Request
` DELETE api/contact/range `

    curl -X DELETE "http://localhost:5004/api/Contact/range" -H  "accept: */*" -H  "Content-Type: application/json" -d "[{\"id\":14,\"name\":\"string\",\"surname\":\"string\",\"company\":\"string\"}]"

### Response

    date: Tue28 Sep 2021 03:04:36 GMT  server: Kestrel  

## Varolan Kişiye Yeni Diğer Bilgi Ekleme

### Request
` POST api/contactInfo `

    curl -X POST "http://localhost:5004/api/ContactInfo?Phone=&Email=&Location=&ContactId=" -H  "accept: */*" -d ""

### Response

    date: Tue28 Sep 2021 03:08:15 GMT  server: Kestrel   

## Kişiden Diğer Bilgilerini Kaldırma

### Request
` DELETE api/contactInfo/id `

    curl -X DELETE "http://localhost:5004/api/ContactInfo/25" -H  "accept: */*"

### Response

    date: Tue28 Sep 2021 03:09:31 GMT  server: Kestrel   


## RAPORLAMA

### Request
` GET api/report `

    curl -X GET "http://localhost:5004/api/Report" -H  "accept: */*"

### Response

    content-type: application/json; charset=utf-8  date: Tue28 Sep 2021 03:10:57 GMT  server: Kestrel  transfer-encoding: chunked    