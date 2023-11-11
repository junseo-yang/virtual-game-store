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
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester4")
driver.find_element(By.ID, "Input_Password").send_keys("Tester4!@")

driver.find_element(By.ID, "login-submit").click()

element = driver.find_element(By.XPATH, "/html/body/div/main/div/div/section/form/div[1]/ul/li")

"""
Assert
"""
assert element.text == "Invalid login attempt."