curl -X POST https://localhost:44303/prescription-add -H accept: */*  -H Content-Type: application/json  -d { "dateOfIssue": "15.01.2020", "doctorName": "Janusz", "doctorSurname": "Nowak", "drugs": [ "apap" ], "expirationDate": "30.01.2020", "patientName": "Norbert", "patientSurname": "Kowalski"}