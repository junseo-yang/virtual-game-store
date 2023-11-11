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

# Change Promotional Email
promotional_email  = driver.find_element(By.ID, "Input_IsPromotionalEmail")
previous_status = promotional_email.get_attribute('checked')
promotional_email.click()

# Click Save
driver.find_element(By.ID, "update-profile-button").click()

"""
Assert
"""
promotional_email  = driver.find_element(By.ID, "Input_IsPromotionalEmail")
current_status = promotional_email.get_attribute('checked')
assert previous_status !=  current_status

"""
Clean up
"""
# Change Promotional Email
promotional_email  = driver.find_element(By.ID, "Input_IsPromotionalEmail")
promotional_email.click()

# Click Save
driver.find_element(By.ID, "update-profile-button").click()