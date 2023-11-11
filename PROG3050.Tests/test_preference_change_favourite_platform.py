from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller
from selenium.webdriver.support.select import Select


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

# Navigates to the Preference page
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.XPATH, "/html/body/header/nav/div/div/ul[2]/div/ul/li[1]/a").click()
driver.find_element(By.ID, "preference").click()

# Click PC Mobile in Favourite Platforms
select = Select(driver.find_element(By.ID, 'favourite_platforms_dropdown'))
select.deselect_all()
select.select_by_visible_text('PC')
select.select_by_visible_text('Console')

# Click Save
driver.find_element(By.ID, "update-profile-button").click()

"""
Assert
"""
select = Select(driver.find_element(By.ID, 'favourite_platforms_dropdown'))
selected_options = [item.text for item in select.all_selected_options]

assert selected_options == ['PC', 'Console']

"""
Clean up
"""
# Click PC to reset
select = Select(driver.find_element(By.ID, 'favourite_platforms_dropdown'))
select.deselect_all()
select.select_by_visible_text('PC')

# Click Save
driver.find_element(By.ID, "update-profile-button").click()