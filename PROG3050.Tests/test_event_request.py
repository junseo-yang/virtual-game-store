from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller
from selenium.webdriver.common.alert import Alert


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
# Tester1 clicks a event button on the navigation
driver.find_element(By.ID, "nav-event").click()

driver.find_element(By.ID, "RegisterEvent1").click()

element = driver.find_element(By.ID, "CancelEvent1")


"""
Assert
"""
assert element.get_attribute("value") == "CancelEvent"

"""
Clean up
"""
driver.find_element(By.ID, "CancelEvent1").click()
driver.quit()