CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    Role INT,
    UserName NVARCHAR(MAX),
    PassWord NVARCHAR(MAX)
);
-- Chèn dữ liệu với Role là 0
INSERT INTO TaiKhoan (Role, UserName, PassWord)
VALUES (0, 'Admin', '123456');

-- Chèn dữ liệu với Role là 1
INSERT INTO TaiKhoan (Role, UserName, PassWord)
VALUES (1, 'UserName2', 'PassWord2');

INSERT INTO TaiKhoan (Role, UserName, PassWord)
VALUES (1, 'UserName3', 'PassWord3');

INSERT INTO TaiKhoan (Role, UserName, PassWord)
VALUES (1, 'UserName4', 'PassWord4');

INSERT INTO TaiKhoan (Role, UserName, PassWord)
VALUES (1, 'UserName5', 'PassWord5');
select * from TaiKhoan where UserName = 'Admin' and PassWord ='123456'