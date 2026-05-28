# Restaurant Management System

## Order
| Object | Function |
|--------|----------|
| `listView_Menu菜單表格` | read from `Order.txt` |
| `comboBox_Type全部商品選項` | read from `Order.txt` |
| `comboBox_AddType類別選項` | read from `Order.txt` |
| `comboBox_AddName商品名稱選項` | read from `Order.txt` |
| `button_Submit送出訂單按鈕` | `listView_Booking訂單表格資料` write in `Cooking.txt`,`Sale.txt` |

<br>

## Cooking
| Object | Function |
|--------|----------|
| `listView_Cooking廚房表格` | read from `Cooking.txt` |
| `listView_Delivery送餐表格` | read from `Delivery.txt` |
| `button_Cooking已製作按鈕` | Select Specify data from `listView_Cooking廚房表格`, and modify data in `Cooking.txt` |
| `button_Delivery已送達按鈕` | Select Specify data from `listView_Delivery送餐表格`, and modify data in `Delivery.txt` |

<br>

## Stuff
| Object | Function |
|--------|----------|
| `listView_In食材表格` | read from `Ingredients.txt` |
| `comboBox_Moded庫存狀態選項` | read from `Ingredients.txt` |
| `comboBox_Type類型選項` | read from `Ingredients.txt` |
| `comboBox_Name產品名稱選項` | read from `Ingredients.txt` |
| `comboBox_Place庫存地點選項` | read from `Ingredients.txt` |
| `comboBox_AddType類型選項` | read from `Ingredients.txt` |
| `comboBox_AddName產品名稱選項` | read from `Ingredients.txt` |
| `button_Save儲存按鈕` | `listView_In食材表格` write in `Ingredients.txt` |

<br>

## Sale
| Object | Function |
|--------|----------|
| `listView_Sale銷售數據表格` | read from `Sale.txt` |
| `comboBox_Type類別選項` | read from `Sale.txt` |
| `comboBox_TableNum桌號選項` | read from `Sale.txt` |

<br>

## Revenue
| Object | Function |
|--------|----------|
| `comboBox_Year年份選項` | read from `Sale.txt` |
| `comboBox_Category商品類別選項` | read from `Sale.txt` |
| `chart1圖表` | data from `Sale.txt` |
