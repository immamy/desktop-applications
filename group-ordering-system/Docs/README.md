# Group Ordering System

## Order
| Object | Function |
|-------|----------------|
| comboBox_Restaurant店家選項 | read from `Restaurant.txt` |
| listView_Menu菜單表格 | read from `Restaurant.txt` |
| button_Menu菜單圖片按鈕 | Download menu picture |
| pictureBox_Menu菜單圖片 | Show partial menu picture |
| comboBox_Name姓名選項 | read from `Deposit.txt` |
| comboBox_Department部門選項 | read from `Deposit.txt` |
| comboBox_Product品名選項 | read from `Restaurant.txt` |
| button_Submit送出訂單按鈕 | listView_Order訂單表格資料 write in `Consumption.txt` |

## Booking
| Object | Function |
|-------|----------------|
| listView_Booking表格 | read from `Consumption.txt` and write in `Booking.txt` |
| listView_Order表格 | read from `Consumption.txt` and write in `Order.txt` |
| comboBox_Restaurant店家選項 | read from `Consumption.txt` |
| comboBox_Department部門選項 | read from `Consumption.txt` |
| label_店家 | read from `Restaurant.txt` |
| label_電話 | read from `Restaurant.txt` |
| label_地址 | read from `Restaurant.txt` |

## Restaurant
| Object | Function |
|-------|----------------|
| listView_Menu表格 | read from `Restaurant.txt` |
| button_Save儲存按鈕 | write in `Restaurant.txt` form `listView_Menu表格` |
| button_Refresh還原按鈕 | read from `Restaurant.txt` and write in `listView_Menu表格` |

## Details
| Object | Function |
|-------|----------------|
| comboBox_Department部門選項 | read from `Deposit.txt` |
| comboBox_Name姓名選項 | read from `Deposit.txt` |
| listView_Detail表格 | read from `Deposit.txt`,`Consumption.txt` |
| button_Download_Person個人按鈕 | read from `Deposit.txt`,`Consumption.txt`,`Balance.txt` and write in `name.txt` from listView_Detail表格(Only Save Specify Person data) |
| button_Download_People所有人按鈕 | read from `Deposit.txt`,`Consumption.txt`,`Balance.txt` and write in `name.txt` from listView_Detail表格(Save all People data) |
| button_Download_allData總表按鈕 | read from `Deposit.txt`,`Consumption.txt` and write in `Detail.txt` from listView_Detail表格(Save all Deposit and Consumption data) |

## Deposit
| Object | Function |
|-------|----------------|
| comboBox_Department部門選項 | read from `Deposit.txt` |
| comboBox_Name姓名選項 | read from `Deposit.txt` |
| listView_Deposit表格 | read from `Deposit.txt` |
| listView_Balance表格 | read from `Deposit.txt`,`Consumption.txt` |
| button_Save儲存按鈕 | write in `Deposit.txt` from listView_Deposit表格, write in `Balance.txt` from listView_Balance表格 |
| button_Refresh還原按鈕 | read from `Deposit.txt` and write in `listView_Deposit表格`, read from `Balance.txt` and write in `listView_Balance表格` |

## People
| Object | Function |
|-------|----------------|
| comboBox_Department部門選項 | read from `People.txt` |
| listView_People表格 | read from `People.txt` |
| button_Save儲存按鈕 | write in `People.txt` form `listView_People表格` |
| button_Refresh還原按鈕 | read from `People.txt` and write in `listView_People表格` |

## Setting
| Object | Function |
|-------|----------------|
| listView_Setting表格 | read from `Setting.txt` |
| button_Save儲存按鈕 | write in `Setting.txt` form `listView_Setting表格` |
| button_Refresh還原按鈕 | read from `Setting.txt` and write in `listView_Setting表格` |
| comboBox_Permissions | read from `Setting.txt` |
| comboBox_Permissions_1 | read from `Setting.txt` |
| comboBox_Permissions_2 | read from `Setting.txt` |
| comboBox_Permissions_3 | read from `Setting.txt` |
| comboBox_Permissions_4 | read from `Setting.txt` |
| comboBox_Department_1 | read from `Deosit.txt` |
| comboBox_Department_2 | read from `Deosit.txt` |
| comboBox_Department_3 | read from `Deosit.txt` |
| comboBox_Department_4 | read from `Deosit.txt` |
| comboBox_Name_1 | read from `Deosit.txt` |
| comboBox_Name_2 | read from `Deosit.txt` |
| comboBox_Name_3 | read from `Deosit.txt` |
| comboBox_Name_4 | read from `Deosit.txt` |
