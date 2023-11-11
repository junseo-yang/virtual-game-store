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
driver.find_element(By.LINK_TEXT, "Register").click()
driver.find_element(By.ID, "Input_UserName").send_keys("Tester3")
driver.find_element(By.ID, "Input_Password").send_keys("Tester3!@")
driver.find_element(By.ID, "Input_ConfirmPassword").send_keys("Tester3!@")

driver.find_element(By.ID, "registerSubmit").click()

"""
Assert
"""
element = driver.find_element(By.XPATH, "/html/body/div[1]/main/div/div/form/div[2]/span/span")


assert element.text == "The Email field is required."