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

# Navigates to the Mailing Address page
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.XPATH, "/html/body/header/nav/div/div/ul[2]/div/ul/li[1]/a").click()
driver.find_element(By.ID, "address").click()

# Update Mailing Address
first_name = driver.find_element(By.ID, 'Input_FirstName')
first_name.clear()
first_name.send_keys('John')

last_name = driver.find_element(By.ID, 'Input_LastName')
last_name.clear()
last_name.send_keys('Smith')

phone_number = driver.find_element(By.ID, 'Input_PhoneNumber')
phone_number.clear()
phone_number.send_keys('226-123-4566')

street = driver.find_element(By.ID, 'Input_Street')
street.clear()
street.send_keys('30 Ontario St')

city = driver.find_element(By.ID, 'Input_City')
city.clear()
city.send_keys('Kitchener')

country = Select(driver.find_element(By.ID, 'Input_CountryId'))
country.select_by_visible_text('Canada')

province = Select(driver.find_element(By.ID, 'Input_ProvinceId'))
province.select_by_visible_text('ON')

postal_code = driver.find_element(By.ID, 'Input_PostalCode')
postal_code.clear()
postal_code.send_keys('N2G 9C1')

# Click Save
driver.find_element(By.ID, "update-profile-button").click()

"""
Assert
"""
first_name = driver.find_element(By.ID, 'Input_FirstName')
last_name = driver.find_element(By.ID, 'Input_LastName')
phone_number = driver.find_element(By.ID, 'Input_PhoneNumber')
street = driver.find_element(By.ID, 'Input_Street')
city = driver.find_element(By.ID, 'Input_City')
country = Select(driver.find_element(By.ID, 'Input_CountryId'))
province = Select(driver.find_element(By.ID, 'Input_ProvinceId'))
postal_code = driver.find_element(By.ID, 'Input_PostalCode')

assert first_name.get_attribute('value') == 'John'
assert last_name.get_attribute('value') == 'Smith'
assert phone_number.get_attribute('value') == '226-123-4566'
assert street.get_attribute('value') == '30 Ontario St'
assert city.get_attribute('value') == 'Kitchener'
assert country.first_selected_option.text == 'Canada'
assert province.first_selected_option.text == 'ON'
assert postal_code.get_attribute('value') == 'N2G 9C1'

"""
Clean up
"""
# Clear all input
first_name.clear()
last_name.clear()
phone_number.clear()
street.clear()
city.clear()
country.select_by_visible_text('Canada')
province.select_by_visible_text('AB')
postal_code.clear()

# Click Save
driver.find_element(By.ID, "update-profile-button").click()