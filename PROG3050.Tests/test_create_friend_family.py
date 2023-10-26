from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller


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

"""
Act
"""
# Tester1 navigates to the users page
driver.get("https://localhost:7239/UserFriendFamilies")

# Tester1 clicks Friend Request to Tester2
driver.find_element(By.XPATH, "/html/body/div/main/table/tbody/tr[4]/td[4]/form/input[2]").click()

# Tester1 logout
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.XPATH, "/html/body/header/nav/div/div/ul[2]/div/ul/li[3]/form/button").click()

# Tester2 login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester2")
driver.find_element(By.ID, "Input_Password").send_keys("Tester2!@")
driver.find_element(By.ID, "login-submit").click()

# Tester2 navigates to the Friend/Family page
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.XPATH, "/html/body/header/nav/div/div/ul[2]/div/ul/li[2]/a").click()

# Tester2 clicks Accept
driver.find_element(By.XPATH, "/html/body/div/main/table/tbody/tr/td[5]/form/input[3]").click()

"""
Assert
"""
# Assert Status is Processed
status = driver.find_element(By.XPATH, "/html/body/div/main/table/tbody/tr/td[4]")
assert status.text == "Processed"

"""
Clean up
"""
# Tester2 clicks Delete button
driver.find_element(By.XPATH, "/html/body/div/main/table/tbody/tr/td[5]/form/input[3]").click()
