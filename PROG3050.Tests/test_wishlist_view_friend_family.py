from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller
from selenium.webdriver.common.alert import Alert


chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
                                      # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

"""
Arrange
"""
# Tester1 navigates to the homepage
driver = webdriver.Chrome()
driver.get("https://localhost:7239/")

# Tester1 login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester1")
driver.find_element(By.ID, "Input_Password").send_keys("Tester1!@")
driver.find_element(By.ID, "login-submit").click()

# Tester1 navigates to the users page
driver.get("https://localhost:7239/UserFriendFamilies")

# Tester1 clicks Friend Request to Tester2
tester_2_index = [i for i, e in enumerate(driver.find_elements(By.TAG_NAME, "td")) if e.text == 'Tester2'][0]
driver.find_element(By.XPATH, f"/html/body/div/main/table/tbody/tr[{tester_2_index//4 + 1}]/td[4]/form/input[2]").click()

# Tester1 logout
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.CSS_SELECTOR, ".btn-link").click()

# Tester2 login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester2")
driver.find_element(By.ID, "Input_Password").send_keys("Tester2!@")
driver.find_element(By.ID, "login-submit").click()

# Tester2 navigates to the Friend/Family page
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.XPATH, "/html/body/header/nav/div/div/ul[2]/div/ul/li[2]/a").click()

# Tester2 clicks Accept on Tester1
tester_1_index = [i for i, e in enumerate(driver.find_elements(By.TAG_NAME, "td")) if e.text == 'Tester1'][0]
driver.find_element(By.XPATH, f"/html/body/div/main/table/tbody/tr[{tester_1_index//5 + 1}]/td[4]/form/input[3]").click()

"""
Act
"""
# Navigates to Tester 1's Wishlist 
driver.find_element(By.XPATH, f"/html/body/div/main/table/tbody/tr[{tester_1_index//5 + 1}]/td[5]/form/input[2]").click()

"""
Assert
"""
assert driver.find_element(By.XPATH, '/html/body/div/main/h1').text == "Tester1's Wishlist"

"""
Clean up
"""
# Navigates to 
driver.get("https://localhost:7239/FriendFamilies")

# Tester2 clicks Delete button on Tester1
driver.find_element(By.XPATH, f"/html/body/div/main/table/tbody/tr[{tester_1_index//5 + 1}]/td[4]/form/input[3]").click()
Alert(driver).accept()
driver.refresh()
driver.quit()