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

"""
Act
"""
# Tester1 navigates to the WishList page
driver.get("https://localhost:7239/WishList")

# Tester1 clicks Share on Reddit
driver.find_element(By.XPATH, f"/html/body/div/main/button").click()

"""
Assert
"""
driver.switch_to.window(driver.window_handles[-1])
url = driver.current_url

# Due to login issue, replace the assert with checking url includes the title
assert 'https://www.reddit.com/r/game/submit?title=WishList%20from%20CVGS!' in url

"""
Clean up
"""
driver.quit()