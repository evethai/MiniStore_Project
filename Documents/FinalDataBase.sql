select * from Voucher
INSERT INTO Voucher (IdVoucher, Name, Type, Price, Quantity, EXP)
VALUES
    ('VO001', 'Voucher A', 'Type A', 10.99, 30, '2023-07-15'),
    ('VO002', 'Voucher B', 'Type B', 15.99, 30, '2023-07-15'),
    ('VO003', 'Voucher C', 'Type C', 5.99, 100, '2023-08-31');
	Delete Voucher where Name like '%Name%'