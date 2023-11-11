from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller


chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
                                      # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

"""
Arrange
"""
driver = webdriver.Chrome()
driver.get("https://localhost:7239/")

"""
Act
"""
# Login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester1")
driver.find_element(By.ID, "Input_Password").send_keys("Tester1!@")

driver.find_element(By.ID, "login-submit").click()

# Navigates to the Profile page
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.XPATH, "/html/body/header/nav/div/div/ul[2]/div/ul/li[1]/a").click()

# Change Name
first_name  = driver.find_element(By.ID, "Input_FirstName")
first_name.clear()
first_name.send_keys("NewTester1FirstName")
last_name = driver.find_element(By.ID, "Input_LastName")
last_name.clear()
last_name.send_keys("NewTester1LastName")

# Click Save
driver.find_element(By.ID, "update-profile-button").click()

"""
Assert
"""
first_name  = driver.find_element(By.ID, "Input_FirstName")
assert first_name.get_attribute('value') == "NewTester1FirstName"
last_name = driver.find_element(By.ID, "Input_LastName")
assert last_name.get_attribute('value') == "NewTester1LastName"

"""
Clean up
"""
# Change Name
first_name  = driver.find_element(By.ID, "Input_FirstName")
first_name.clear()
first_name.send_keys("Test1FirstName")
last_name = driver.find_element(By.ID, "Input_LastName")
last_name.clear()
last_name.send_keys("Test1LastName")

# Click Save
driver.find_element(By.ID, "update-profile-button").click()