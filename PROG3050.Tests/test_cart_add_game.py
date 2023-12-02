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

"""
Act
"""
# Tester1 login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester1")
driver.find_element(By.ID, "Input_Password").send_keys("Tester1!@")
driver.find_element(By.ID, "login-submit").click()

# Tester1 navigates to the games page
driver.find_element(By.ID, "nav-game").click()

# Tester1 clicks add to cart on a game
driver.find_element(By.CSS_SELECTOR, "tr:nth-child(2) .d-inline-block .btn").click()

# Tester1 navigates to the cart page
driver.find_element(By.LINK_TEXT, "View Cart").click()

"""
Assert
"""
# Assert element text is Star Trek: Infinite
assert driver.find_element(By.CSS_SELECTOR, "td:nth-child(1)").text == "Star Trek: Infinite"

"""
Clean up
"""
# Logout
driver.find_element(By.CSS_SELECTOR, "btn-danger").click()
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.CSS_SELECTOR, ".btn-link").click()

driver.quit()